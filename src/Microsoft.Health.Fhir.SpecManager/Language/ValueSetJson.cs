// <copyright file="CSharpBasic.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using Microsoft.Health.Fhir.SpecManager.Manager;
using Microsoft.Health.Fhir.SpecManager.Models;

namespace Microsoft.Health.Fhir.SpecManager.Language
{
    /// <summary>A basic langauge for exporting value set information.</summary>
    public sealed class ValueSetJson : ILanguage
    {
        /// <summary>FHIR information we are exporting.</summary>
        private FhirVersionInfo _info;

        /// <summary>Options for controlling the export.</summary>
        private ExporterOptions _options;

        /// <summary>Name of the language.</summary>
        private const string _languageName = "ValueSetJson";

        /// <summary>Gets the name of the language.</summary>
        /// <value>The name of the language.</value>
        string ILanguage.LanguageName => _languageName;

        /// <summary>
        /// Gets the single file extension for this language - null or empty indicates a multi-file
        /// export (exporter should copy the contents of the directory).
        /// </summary>
        string ILanguage.SingleFileExportExtension => ".json";

        /// <summary>Gets the FHIR primitive type map.</summary>
        /// <value>The FHIR primitive type map.</value>
        Dictionary<string, string> ILanguage.FhirPrimitiveTypeMap => new Dictionary<string, string>();

        /// <summary>Gets the reserved words.</summary>
        /// <value>The reserved words.</value>
        HashSet<string> ILanguage.ReservedWords => new HashSet<string>();

        /// <summary>
        /// Gets a list of FHIR class types that the language WILL export, regardless of user choices.
        /// Used to provide information to users.
        /// </summary>
        List<ExporterOptions.FhirExportClassType> ILanguage.RequiredExportClassTypes => new List<ExporterOptions.FhirExportClassType>()
        {
            ExporterOptions.FhirExportClassType.PrimitiveType,
            ExporterOptions.FhirExportClassType.ComplexType,
            ExporterOptions.FhirExportClassType.Resource,
            ExporterOptions.FhirExportClassType.Profile,
            ExporterOptions.FhirExportClassType.Enum,
        };

        /// <summary>
        /// Gets a list of FHIR class types that the language CAN export, depending on user choices.
        /// </summary>
        List<ExporterOptions.FhirExportClassType> ILanguage.OptionalExportClassTypes => new List<ExporterOptions.FhirExportClassType>()
        {
        };

        /// <summary>Gets language-specific options and their descriptions.</summary>
        Dictionary<string, string> ILanguage.LanguageOptions => new Dictionary<string, string>()
        {
        };

        /// <summary>Export the passed FHIR version into the specified directory.</summary>
        /// <param name="info">           The information.</param>
        /// <param name="serverInfo">     Information describing the server.</param>
        /// <param name="options">        Options for controlling the operation.</param>
        /// <param name="exportDirectory">Directory to write files.</param>
        void ILanguage.Export(
            FhirVersionInfo info,
            FhirServerInfo serverInfo,
            ExporterOptions options,
            string exportDirectory)
        {
            // set internal vars so we don't pass them to every function
            // this is ugly, but the interface patterns get bad quickly because we need the type map to copy the FHIR info
            _info = info;
            _options = options;

            Dictionary<string, string> vsByPath = GetValueSets();

            Dictionary<string, HashSet<string>> csByPath = GetCodeSystems(vsByPath);

            // create a filename for writing (single file for now)
            string filename = Path.Combine(exportDirectory, $"ValueSetInfoR{info.MajorVersion}.json");

            using (FileStream stream = new FileStream(filename, FileMode.Create))
            using (Utf8JsonWriter writer = new Utf8JsonWriter(stream))
            {
                System.Text.Json.JsonSerializer.Serialize(writer, csByPath);
            }
        }

        private Dictionary<string, HashSet<string>> GetCodeSystems(Dictionary<string, string> vsByPath)
        {
            Dictionary<string, HashSet<string>> csByPath = new Dictionary<string, HashSet<string>>();

            foreach (KeyValuePair<string, string> kvp in vsByPath.OrderBy(v => v.Key))
            {
                string path = kvp.Key;
                string vsUrl = kvp.Value;

                if (_info.TryGetValueSet(vsUrl, out FhirValueSet vs))
                {
                    if (vs.ReferencedCodeSystems.Count > 0)
                    {
                        csByPath.Add(path, vs.ReferencedCodeSystems);
                        continue;
                    }

                    csByPath.Add(path, new HashSet<string>());

                    foreach (FhirConcept concept in vs.Concepts)
                    {
                        if (string.IsNullOrEmpty(concept.System))
                        {
                            continue;
                        }

                        if (csByPath[path].Contains(concept.System))
                        {
                            continue;
                        }

                        csByPath[path].Add(concept.System);
                    }
                }
            }

            return csByPath;
        }

        private void AddComplexValueSets(FhirComplex complex, Dictionary<string, string> valueSetsByPath)
        {
            if (complex.Components != null)
            {
                foreach (FhirComplex component in complex.Components.Values)
                {
                    AddComplexValueSets(component, valueSetsByPath);
                }
            }

            foreach (FhirElement element in complex.Elements.Values)
            {
                if (!string.IsNullOrEmpty(element.ValueSet))
                {
                    if (element.Path == "Extension.value[x]")
                    {
                        continue;
                    }

                    string path = element.Path;

                    if (path.Contains("[x]", StringComparison.Ordinal))
                    {
                        path = path.Replace("[x]", string.Empty, StringComparison.Ordinal);
                    }

                    valueSetsByPath.Add(path, element.ValueSet);
                }
            }
        }

        /// <summary>Process the value sets.</summary>
        /// <returns>A Dictionary&lt;string,string&gt;</returns>
        private Dictionary<string, string> GetValueSets()
        {
            Dictionary<string, string> valueSetsByPath = new Dictionary<string, string>();

            foreach (FhirComplex complex in _info.ComplexTypes.Values)
            {
                AddComplexValueSets(complex, valueSetsByPath);
            }

            foreach (FhirComplex complex in _info.Resources.Values)
            {
                AddComplexValueSets(complex, valueSetsByPath);
            }

            return valueSetsByPath;
        }
    }
}
