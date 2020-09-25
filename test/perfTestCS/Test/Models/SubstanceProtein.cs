// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.R4.ValueSets;
using Fhir.R4.Serialization;

namespace Fhir.R4.Models
{
  /// <summary>
  /// This subclause refers to the description of each subunit constituting the SubstanceProtein. A subunit is a linear sequence of amino acids linked through peptide bonds. The Subunit information shall be provided when the finished SubstanceProtein is a complex of multiple sequences; subunits are not used to delineate domains within a single sequence. Subunits are listed in order of decreasing length; sequences of the same length will be ordered by decreasing molecular weight; subunits that have identical sequences will be repeated multiple times.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<SubstanceProteinSubunit>))]
  public class SubstanceProteinSubunit : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The modification at the C-terminal shall be specified.
    /// </summary>
    public string CTerminalModification { get; set; }
    /// <summary>
    /// Extension container element for CTerminalModification
    /// </summary>
    public Element _CTerminalModification { get; set; }
    /// <summary>
    /// Unique identifier for molecular fragment modification based on the ISO 11238 Substance ID.
    /// </summary>
    public Identifier CTerminalModificationId { get; set; }
    /// <summary>
    /// Length of linear sequences of amino acids contained in the subunit.
    /// </summary>
    public int? Length { get; set; }
    /// <summary>
    /// The name of the fragment modified at the N-terminal of the SubstanceProtein shall be specified.
    /// </summary>
    public string NTerminalModification { get; set; }
    /// <summary>
    /// Extension container element for NTerminalModification
    /// </summary>
    public Element _NTerminalModification { get; set; }
    /// <summary>
    /// Unique identifier for molecular fragment modification based on the ISO 11238 Substance ID.
    /// </summary>
    public Identifier NTerminalModificationId { get; set; }
    /// <summary>
    /// The sequence information shall be provided enumerating the amino acids from N- to C-terminal end using standard single-letter amino acid codes. Uppercase shall be used for L-amino acids and lowercase for D-amino acids. Transcribed SubstanceProteins will always be described using the translated sequence; for synthetic peptide containing amino acids that are not represented with a single letter code an X should be used within the sequence. The modified amino acids will be distinguished by their position in the sequence.
    /// </summary>
    public string Sequence { get; set; }
    /// <summary>
    /// Extension container element for Sequence
    /// </summary>
    public Element _Sequence { get; set; }
    /// <summary>
    /// The sequence information shall be provided enumerating the amino acids from N- to C-terminal end using standard single-letter amino acid codes. Uppercase shall be used for L-amino acids and lowercase for D-amino acids. Transcribed SubstanceProteins will always be described using the translated sequence; for synthetic peptide containing amino acids that are not represented with a single letter code an X should be used within the sequence. The modified amino acids will be distinguished by their position in the sequence.
    /// </summary>
    public Attachment SequenceAttachment { get; set; }
    /// <summary>
    /// Index of primary sequences of amino acids linked through peptide bonds in order of decreasing length. Sequences of the same length will be ordered by molecular weight. Subunits that have identical sequences will be repeated and have sequential subscripts.
    /// </summary>
    public int? Subunit { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(ref Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(ref writer, options, false);

      writer.WriteString("cTerminalModification", CTerminalModification);

      if (_CTerminalModification != null)
      {
        writer.WritePropertyName("_cTerminalModification");
        _CTerminalModification.SerializeJson(ref writer, options);
      }

      if (CTerminalModificationId != null)
      {
        writer.WritePropertyName("cTerminalModificationId");
        CTerminalModificationId.SerializeJson(ref writer, options);
      }

      if (Length != null)
      {
        writer.WriteNumber("length", (int)Length!);
      }

      writer.WriteString("nTerminalModification", NTerminalModification);

      if (_NTerminalModification != null)
      {
        writer.WritePropertyName("_nTerminalModification");
        _NTerminalModification.SerializeJson(ref writer, options);
      }

      if (NTerminalModificationId != null)
      {
        writer.WritePropertyName("nTerminalModificationId");
        NTerminalModificationId.SerializeJson(ref writer, options);
      }

      writer.WriteString("sequence", Sequence);

      if (_Sequence != null)
      {
        writer.WritePropertyName("_sequence");
        _Sequence.SerializeJson(ref writer, options);
      }

      if (SequenceAttachment != null)
      {
        writer.WritePropertyName("sequenceAttachment");
        SequenceAttachment.SerializeJson(ref writer, options);
      }

      if (Subunit != null)
      {
        writer.WriteNumber("subunit", (int)Subunit!);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "cTerminalModification":
          CTerminalModification = reader.GetString();
          break;

        case "_cTerminalModification":
          _CTerminalModification = new Fhir.R4.Models.Element();
          _CTerminalModification.DeserializeJson(ref reader, options);
          break;

        case "cTerminalModificationId":
          CTerminalModificationId = new Fhir.R4.Models.Identifier();
          CTerminalModificationId.DeserializeJson(ref reader, options);
          break;

        case "length":
          Length = reader.GetInt32();
          break;

        case "nTerminalModification":
          NTerminalModification = reader.GetString();
          break;

        case "_nTerminalModification":
          _NTerminalModification = new Fhir.R4.Models.Element();
          _NTerminalModification.DeserializeJson(ref reader, options);
          break;

        case "nTerminalModificationId":
          NTerminalModificationId = new Fhir.R4.Models.Identifier();
          NTerminalModificationId.DeserializeJson(ref reader, options);
          break;

        case "sequence":
          Sequence = reader.GetString();
          break;

        case "_sequence":
          _Sequence = new Fhir.R4.Models.Element();
          _Sequence.DeserializeJson(ref reader, options);
          break;

        case "sequenceAttachment":
          SequenceAttachment = new Fhir.R4.Models.Attachment();
          SequenceAttachment.DeserializeJson(ref reader, options);
          break;

        case "subunit":
          Subunit = reader.GetInt32();
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// A SubstanceProtein is defined as a single unit of a linear amino acid sequence, or a combination of subunits that are either covalently linked or have a defined invariant stoichiometric relationship. This includes all synthetic, recombinant and purified SubstanceProteins of defined sequence, whether the use is therapeutic or prophylactic. This set of elements will be used to describe albumins, coagulation factors, cytokines, growth factors, peptide/SubstanceProtein hormones, enzymes, toxins, toxoids, recombinant vaccines, and immunomodulators.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class SubstanceProtein : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "SubstanceProtein";
    /// <summary>
    /// The disulphide bond between two cysteine residues either on the same subunit or on two different subunits shall be described. The position of the disulfide bonds in the SubstanceProtein shall be listed in increasing order of subunit number and position within subunit followed by the abbreviation of the amino acids involved. The disulfide linkage positions shall actually contain the amino acid Cysteine at the respective positions.
    /// </summary>
    public List<string> DisulfideLinkage { get; set; }
    /// <summary>
    /// Extension container element for DisulfideLinkage
    /// </summary>
    public List<Element> _DisulfideLinkage { get; set; }
    /// <summary>
    /// Number of linear sequences of amino acids linked through peptide bonds. The number of subunits constituting the SubstanceProtein shall be described. It is possible that the number of subunits can be variable.
    /// </summary>
    public int? NumberOfSubunits { get; set; }
    /// <summary>
    /// The SubstanceProtein descriptive elements will only be used when a complete or partial amino acid sequence is available or derivable from a nucleic acid sequence.
    /// </summary>
    public CodeableConcept SequenceType { get; set; }
    /// <summary>
    /// This subclause refers to the description of each subunit constituting the SubstanceProtein. A subunit is a linear sequence of amino acids linked through peptide bonds. The Subunit information shall be provided when the finished SubstanceProtein is a complex of multiple sequences; subunits are not used to delineate domains within a single sequence. Subunits are listed in order of decreasing length; sequences of the same length will be ordered by decreasing molecular weight; subunits that have identical sequences will be repeated multiple times.
    /// </summary>
    public List<SubstanceProteinSubunit> Subunit { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(ref Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      writer.WriteString("resourceType", ResourceType);


      ((Fhir.R4.Models.DomainResource)this).SerializeJson(ref writer, options, false);

      if ((DisulfideLinkage != null) && (DisulfideLinkage.Count != 0))
      {
        writer.WritePropertyName("disulfideLinkage");
        writer.WriteStartArray();

        foreach (string valDisulfideLinkage in DisulfideLinkage)
        {
          writer.WriteStringValue(valDisulfideLinkage);
        }

        writer.WriteEndArray();
      }

      if ((_DisulfideLinkage != null) && (_DisulfideLinkage.Count != 0))
      {
        writer.WritePropertyName("_disulfideLinkage");
        writer.WriteStartArray();

        foreach (Element val_DisulfideLinkage in _DisulfideLinkage)
        {
          val_DisulfideLinkage.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (NumberOfSubunits != null)
      {
        writer.WriteNumber("numberOfSubunits", (int)NumberOfSubunits!);
      }

      if (SequenceType != null)
      {
        writer.WritePropertyName("sequenceType");
        SequenceType.SerializeJson(ref writer, options);
      }

      if ((Subunit != null) && (Subunit.Count != 0))
      {
        writer.WritePropertyName("subunit");
        writer.WriteStartArray();

        foreach (SubstanceProteinSubunit valSubunit in Subunit)
        {
          valSubunit.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "disulfideLinkage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          DisulfideLinkage = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            DisulfideLinkage.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (DisulfideLinkage.Count == 0)
          {
            DisulfideLinkage = null;
          }

          break;

        case "_disulfideLinkage":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _DisulfideLinkage = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_DisulfideLinkage = new Fhir.R4.Models.Element();
            obj_DisulfideLinkage.DeserializeJson(ref reader, options);
            _DisulfideLinkage.Add(obj_DisulfideLinkage);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_DisulfideLinkage.Count == 0)
          {
            _DisulfideLinkage = null;
          }

          break;

        case "numberOfSubunits":
          NumberOfSubunits = reader.GetInt32();
          break;

        case "sequenceType":
          SequenceType = new Fhir.R4.Models.CodeableConcept();
          SequenceType.DeserializeJson(ref reader, options);
          break;

        case "subunit":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Subunit = new List<SubstanceProteinSubunit>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.SubstanceProteinSubunit objSubunit = new Fhir.R4.Models.SubstanceProteinSubunit();
            objSubunit.DeserializeJson(ref reader, options);
            Subunit.Add(objSubunit);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Subunit.Count == 0)
          {
            Subunit = null;
          }

          break;

        default:
          ((Fhir.R4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}
