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
  /// A parameter passed to or received from the operation.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<ParametersParameter>))]
  public class ParametersParameter : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The name of the parameter (reference to the operation definition).
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// Only one level of nested parameters is allowed.
    /// </summary>
    public List<ParametersParameter> Part { get; set; }
    /// <summary>
    /// When resolving references in resources, the operation definition may specify how references may be resolved between parameters. If a reference cannot be resolved between the parameters, the application should fall back to it's general resource resolution methods.
    /// </summary>
    public Resource Resource { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueBase64Binary { get; set; }
    /// <summary>
    /// Extension container element for ValueBase64Binary
    /// </summary>
    public Element _ValueBase64Binary { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public bool? ValueBoolean { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueCanonical { get; set; }
    /// <summary>
    /// Extension container element for ValueCanonical
    /// </summary>
    public Element _ValueCanonical { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueCode { get; set; }
    /// <summary>
    /// Extension container element for ValueCode
    /// </summary>
    public Element _ValueCode { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueDate { get; set; }
    /// <summary>
    /// Extension container element for ValueDate
    /// </summary>
    public Element _ValueDate { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueDateTime { get; set; }
    /// <summary>
    /// Extension container element for ValueDateTime
    /// </summary>
    public Element _ValueDateTime { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public decimal? ValueDecimal { get; set; }
    /// <summary>
    /// Extension container element for ValueDecimal
    /// </summary>
    public Element _ValueDecimal { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueId { get; set; }
    /// <summary>
    /// Extension container element for ValueId
    /// </summary>
    public Element _ValueId { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueInstant { get; set; }
    /// <summary>
    /// Extension container element for ValueInstant
    /// </summary>
    public Element _ValueInstant { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public int? ValueInteger { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueMarkdown { get; set; }
    /// <summary>
    /// Extension container element for ValueMarkdown
    /// </summary>
    public Element _ValueMarkdown { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueOid { get; set; }
    /// <summary>
    /// Extension container element for ValueOid
    /// </summary>
    public Element _ValueOid { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public uint? ValuePositiveInt { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueString { get; set; }
    /// <summary>
    /// Extension container element for ValueString
    /// </summary>
    public Element _ValueString { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueTime { get; set; }
    /// <summary>
    /// Extension container element for ValueTime
    /// </summary>
    public Element _ValueTime { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public uint? ValueUnsignedInt { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueUri { get; set; }
    /// <summary>
    /// Extension container element for ValueUri
    /// </summary>
    public Element _ValueUri { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public string ValueUrl { get; set; }
    /// <summary>
    /// Extension container element for ValueUrl
    /// </summary>
    public Element _ValueUrl { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Guid? ValueUuid { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Address ValueAddress { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Age ValueAge { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Annotation ValueAnnotation { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Attachment ValueAttachment { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public CodeableConcept ValueCodeableConcept { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Coding ValueCoding { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public ContactPoint ValueContactPoint { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Count ValueCount { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Distance ValueDistance { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Duration ValueDuration { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public HumanName ValueHumanName { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Identifier ValueIdentifier { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Money ValueMoney { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Period ValuePeriod { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Quantity ValueQuantity { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Range ValueRange { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Ratio ValueRatio { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Reference ValueReference { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public SampledData ValueSampledData { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Signature ValueSignature { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Timing ValueTiming { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public ContactDetail ValueContactDetail { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Contributor ValueContributor { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public DataRequirement ValueDataRequirement { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Expression ValueExpression { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public ParameterDefinition ValueParameterDefinition { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public RelatedArtifact ValueRelatedArtifact { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public TriggerDefinition ValueTriggerDefinition { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public UsageContext ValueUsageContext { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Dosage ValueDosage { get; set; }
    /// <summary>
    /// If the parameter is a data type.
    /// </summary>
    public Meta ValueMeta { get; set; }
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

      writer.WriteString("name", Name);

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(ref writer, options);
      }

      if ((Part != null) && (Part.Count != 0))
      {
        writer.WritePropertyName("part");
        writer.WriteStartArray();

        foreach (ParametersParameter valPart in Part)
        {
          valPart.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Resource != null)
      {
        writer.WritePropertyName("resource");
        JsonSerializer.Serialize<Fhir.R4.Models.Resource>(writer, (Fhir.R4.Models.Resource)Resource, options);
      }

      writer.WriteString("valueBase64Binary", ValueBase64Binary);

      if (_ValueBase64Binary != null)
      {
        writer.WritePropertyName("_valueBase64Binary");
        _ValueBase64Binary.SerializeJson(ref writer, options);
      }

      if (ValueBoolean != null)
      {
        writer.WriteBoolean("valueBoolean", (bool)ValueBoolean!);
      }

      writer.WriteString("valueCanonical", ValueCanonical);

      if (_ValueCanonical != null)
      {
        writer.WritePropertyName("_valueCanonical");
        _ValueCanonical.SerializeJson(ref writer, options);
      }

      writer.WriteString("valueCode", ValueCode);

      if (_ValueCode != null)
      {
        writer.WritePropertyName("_valueCode");
        _ValueCode.SerializeJson(ref writer, options);
      }

      writer.WriteString("valueDate", ValueDate);

      if (_ValueDate != null)
      {
        writer.WritePropertyName("_valueDate");
        _ValueDate.SerializeJson(ref writer, options);
      }

      writer.WriteString("valueDateTime", ValueDateTime);

      if (_ValueDateTime != null)
      {
        writer.WritePropertyName("_valueDateTime");
        _ValueDateTime.SerializeJson(ref writer, options);
      }

      if (ValueDecimal != null)
      {
        writer.WriteNumber("valueDecimal", (decimal)ValueDecimal!);
      }

      if (_ValueDecimal != null)
      {
        writer.WritePropertyName("_valueDecimal");
        _ValueDecimal.SerializeJson(ref writer, options);
      }

      writer.WriteString("valueId", ValueId);

      if (_ValueId != null)
      {
        writer.WritePropertyName("_valueId");
        _ValueId.SerializeJson(ref writer, options);
      }

      writer.WriteString("valueInstant", ValueInstant);

      if (_ValueInstant != null)
      {
        writer.WritePropertyName("_valueInstant");
        _ValueInstant.SerializeJson(ref writer, options);
      }

      if (ValueInteger != null)
      {
        writer.WriteNumber("valueInteger", (int)ValueInteger!);
      }

      writer.WriteString("valueMarkdown", ValueMarkdown);

      if (_ValueMarkdown != null)
      {
        writer.WritePropertyName("_valueMarkdown");
        _ValueMarkdown.SerializeJson(ref writer, options);
      }

      writer.WriteString("valueOid", ValueOid);

      if (_ValueOid != null)
      {
        writer.WritePropertyName("_valueOid");
        _ValueOid.SerializeJson(ref writer, options);
      }

      if (ValuePositiveInt != null)
      {
        writer.WriteNumber("valuePositiveInt", (uint)ValuePositiveInt!);
      }

      writer.WriteString("valueString", ValueString);

      if (_ValueString != null)
      {
        writer.WritePropertyName("_valueString");
        _ValueString.SerializeJson(ref writer, options);
      }

      writer.WriteString("valueTime", ValueTime);

      if (_ValueTime != null)
      {
        writer.WritePropertyName("_valueTime");
        _ValueTime.SerializeJson(ref writer, options);
      }

      if (ValueUnsignedInt != null)
      {
        writer.WriteNumber("valueUnsignedInt", (uint)ValueUnsignedInt!);
      }

      writer.WriteString("valueUri", ValueUri);

      if (_ValueUri != null)
      {
        writer.WritePropertyName("_valueUri");
        _ValueUri.SerializeJson(ref writer, options);
      }

      writer.WriteString("valueUrl", ValueUrl);

      if (_ValueUrl != null)
      {
        writer.WritePropertyName("_valueUrl");
        _ValueUrl.SerializeJson(ref writer, options);
      }

      if (ValueUuid != null)
      {
        writer.WriteString("valueUuid", (Guid)ValueUuid!);
      }

      if (ValueAddress != null)
      {
        writer.WritePropertyName("valueAddress");
        ValueAddress.SerializeJson(ref writer, options);
      }

      if (ValueAge != null)
      {
        writer.WritePropertyName("valueAge");
        ValueAge.SerializeJson(ref writer, options);
      }

      if (ValueAnnotation != null)
      {
        writer.WritePropertyName("valueAnnotation");
        ValueAnnotation.SerializeJson(ref writer, options);
      }

      if (ValueAttachment != null)
      {
        writer.WritePropertyName("valueAttachment");
        ValueAttachment.SerializeJson(ref writer, options);
      }

      if (ValueCodeableConcept != null)
      {
        writer.WritePropertyName("valueCodeableConcept");
        ValueCodeableConcept.SerializeJson(ref writer, options);
      }

      if (ValueCoding != null)
      {
        writer.WritePropertyName("valueCoding");
        ValueCoding.SerializeJson(ref writer, options);
      }

      if (ValueContactPoint != null)
      {
        writer.WritePropertyName("valueContactPoint");
        ValueContactPoint.SerializeJson(ref writer, options);
      }

      if (ValueCount != null)
      {
        writer.WritePropertyName("valueCount");
        ValueCount.SerializeJson(ref writer, options);
      }

      if (ValueDistance != null)
      {
        writer.WritePropertyName("valueDistance");
        ValueDistance.SerializeJson(ref writer, options);
      }

      if (ValueDuration != null)
      {
        writer.WritePropertyName("valueDuration");
        ValueDuration.SerializeJson(ref writer, options);
      }

      if (ValueHumanName != null)
      {
        writer.WritePropertyName("valueHumanName");
        ValueHumanName.SerializeJson(ref writer, options);
      }

      if (ValueIdentifier != null)
      {
        writer.WritePropertyName("valueIdentifier");
        ValueIdentifier.SerializeJson(ref writer, options);
      }

      if (ValueMoney != null)
      {
        writer.WritePropertyName("valueMoney");
        ValueMoney.SerializeJson(ref writer, options);
      }

      if (ValuePeriod != null)
      {
        writer.WritePropertyName("valuePeriod");
        ValuePeriod.SerializeJson(ref writer, options);
      }

      if (ValueQuantity != null)
      {
        writer.WritePropertyName("valueQuantity");
        ValueQuantity.SerializeJson(ref writer, options);
      }

      if (ValueRange != null)
      {
        writer.WritePropertyName("valueRange");
        ValueRange.SerializeJson(ref writer, options);
      }

      if (ValueRatio != null)
      {
        writer.WritePropertyName("valueRatio");
        ValueRatio.SerializeJson(ref writer, options);
      }

      if (ValueReference != null)
      {
        writer.WritePropertyName("valueReference");
        ValueReference.SerializeJson(ref writer, options);
      }

      if (ValueSampledData != null)
      {
        writer.WritePropertyName("valueSampledData");
        ValueSampledData.SerializeJson(ref writer, options);
      }

      if (ValueSignature != null)
      {
        writer.WritePropertyName("valueSignature");
        ValueSignature.SerializeJson(ref writer, options);
      }

      if (ValueTiming != null)
      {
        writer.WritePropertyName("valueTiming");
        ValueTiming.SerializeJson(ref writer, options);
      }

      if (ValueContactDetail != null)
      {
        writer.WritePropertyName("valueContactDetail");
        ValueContactDetail.SerializeJson(ref writer, options);
      }

      if (ValueContributor != null)
      {
        writer.WritePropertyName("valueContributor");
        ValueContributor.SerializeJson(ref writer, options);
      }

      if (ValueDataRequirement != null)
      {
        writer.WritePropertyName("valueDataRequirement");
        ValueDataRequirement.SerializeJson(ref writer, options);
      }

      if (ValueExpression != null)
      {
        writer.WritePropertyName("valueExpression");
        ValueExpression.SerializeJson(ref writer, options);
      }

      if (ValueParameterDefinition != null)
      {
        writer.WritePropertyName("valueParameterDefinition");
        ValueParameterDefinition.SerializeJson(ref writer, options);
      }

      if (ValueRelatedArtifact != null)
      {
        writer.WritePropertyName("valueRelatedArtifact");
        ValueRelatedArtifact.SerializeJson(ref writer, options);
      }

      if (ValueTriggerDefinition != null)
      {
        writer.WritePropertyName("valueTriggerDefinition");
        ValueTriggerDefinition.SerializeJson(ref writer, options);
      }

      if (ValueUsageContext != null)
      {
        writer.WritePropertyName("valueUsageContext");
        ValueUsageContext.SerializeJson(ref writer, options);
      }

      if (ValueDosage != null)
      {
        writer.WritePropertyName("valueDosage");
        ValueDosage.SerializeJson(ref writer, options);
      }

      if (ValueMeta != null)
      {
        writer.WritePropertyName("valueMeta");
        ValueMeta.SerializeJson(ref writer, options);
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
        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new Fhir.R4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "part":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Part = new List<ParametersParameter>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ParametersParameter objPart = new Fhir.R4.Models.ParametersParameter();
            objPart.DeserializeJson(ref reader, options);
            Part.Add(objPart);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Part.Count == 0)
          {
            Part = null;
          }

          break;

        case "resource":
          Resource = JsonSerializer.Deserialize<Fhir.R4.Models.Resource>(ref reader, options);
          break;

        case "valueBase64Binary":
          ValueBase64Binary = reader.GetString();
          break;

        case "_valueBase64Binary":
          _ValueBase64Binary = new Fhir.R4.Models.Element();
          _ValueBase64Binary.DeserializeJson(ref reader, options);
          break;

        case "valueBoolean":
          ValueBoolean = reader.GetBoolean();
          break;

        case "valueCanonical":
          ValueCanonical = reader.GetString();
          break;

        case "_valueCanonical":
          _ValueCanonical = new Fhir.R4.Models.Element();
          _ValueCanonical.DeserializeJson(ref reader, options);
          break;

        case "valueCode":
          ValueCode = reader.GetString();
          break;

        case "_valueCode":
          _ValueCode = new Fhir.R4.Models.Element();
          _ValueCode.DeserializeJson(ref reader, options);
          break;

        case "valueDate":
          ValueDate = reader.GetString();
          break;

        case "_valueDate":
          _ValueDate = new Fhir.R4.Models.Element();
          _ValueDate.DeserializeJson(ref reader, options);
          break;

        case "valueDateTime":
          ValueDateTime = reader.GetString();
          break;

        case "_valueDateTime":
          _ValueDateTime = new Fhir.R4.Models.Element();
          _ValueDateTime.DeserializeJson(ref reader, options);
          break;

        case "valueDecimal":
          ValueDecimal = reader.GetDecimal();
          break;

        case "_valueDecimal":
          _ValueDecimal = new Fhir.R4.Models.Element();
          _ValueDecimal.DeserializeJson(ref reader, options);
          break;

        case "valueId":
          ValueId = reader.GetString();
          break;

        case "_valueId":
          _ValueId = new Fhir.R4.Models.Element();
          _ValueId.DeserializeJson(ref reader, options);
          break;

        case "valueInstant":
          ValueInstant = reader.GetString();
          break;

        case "_valueInstant":
          _ValueInstant = new Fhir.R4.Models.Element();
          _ValueInstant.DeserializeJson(ref reader, options);
          break;

        case "valueInteger":
          ValueInteger = reader.GetInt32();
          break;

        case "valueMarkdown":
          ValueMarkdown = reader.GetString();
          break;

        case "_valueMarkdown":
          _ValueMarkdown = new Fhir.R4.Models.Element();
          _ValueMarkdown.DeserializeJson(ref reader, options);
          break;

        case "valueOid":
          ValueOid = reader.GetString();
          break;

        case "_valueOid":
          _ValueOid = new Fhir.R4.Models.Element();
          _ValueOid.DeserializeJson(ref reader, options);
          break;

        case "valuePositiveInt":
          ValuePositiveInt = reader.GetUInt32();
          break;

        case "valueString":
          ValueString = reader.GetString();
          break;

        case "_valueString":
          _ValueString = new Fhir.R4.Models.Element();
          _ValueString.DeserializeJson(ref reader, options);
          break;

        case "valueTime":
          ValueTime = reader.GetString();
          break;

        case "_valueTime":
          _ValueTime = new Fhir.R4.Models.Element();
          _ValueTime.DeserializeJson(ref reader, options);
          break;

        case "valueUnsignedInt":
          ValueUnsignedInt = reader.GetUInt32();
          break;

        case "valueUri":
          ValueUri = reader.GetString();
          break;

        case "_valueUri":
          _ValueUri = new Fhir.R4.Models.Element();
          _ValueUri.DeserializeJson(ref reader, options);
          break;

        case "valueUrl":
          ValueUrl = reader.GetString();
          break;

        case "_valueUrl":
          _ValueUrl = new Fhir.R4.Models.Element();
          _ValueUrl.DeserializeJson(ref reader, options);
          break;

        case "valueUuid":
          ValueUuid = reader.GetGuid();
          break;

        case "valueAddress":
          ValueAddress = new Fhir.R4.Models.Address();
          ValueAddress.DeserializeJson(ref reader, options);
          break;

        case "valueAge":
          ValueAge = new Fhir.R4.Models.Age();
          ValueAge.DeserializeJson(ref reader, options);
          break;

        case "valueAnnotation":
          ValueAnnotation = new Fhir.R4.Models.Annotation();
          ValueAnnotation.DeserializeJson(ref reader, options);
          break;

        case "valueAttachment":
          ValueAttachment = new Fhir.R4.Models.Attachment();
          ValueAttachment.DeserializeJson(ref reader, options);
          break;

        case "valueCodeableConcept":
          ValueCodeableConcept = new Fhir.R4.Models.CodeableConcept();
          ValueCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "valueCoding":
          ValueCoding = new Fhir.R4.Models.Coding();
          ValueCoding.DeserializeJson(ref reader, options);
          break;

        case "valueContactPoint":
          ValueContactPoint = new Fhir.R4.Models.ContactPoint();
          ValueContactPoint.DeserializeJson(ref reader, options);
          break;

        case "valueCount":
          ValueCount = new Fhir.R4.Models.Count();
          ValueCount.DeserializeJson(ref reader, options);
          break;

        case "valueDistance":
          ValueDistance = new Fhir.R4.Models.Distance();
          ValueDistance.DeserializeJson(ref reader, options);
          break;

        case "valueDuration":
          ValueDuration = new Fhir.R4.Models.Duration();
          ValueDuration.DeserializeJson(ref reader, options);
          break;

        case "valueHumanName":
          ValueHumanName = new Fhir.R4.Models.HumanName();
          ValueHumanName.DeserializeJson(ref reader, options);
          break;

        case "valueIdentifier":
          ValueIdentifier = new Fhir.R4.Models.Identifier();
          ValueIdentifier.DeserializeJson(ref reader, options);
          break;

        case "valueMoney":
          ValueMoney = new Fhir.R4.Models.Money();
          ValueMoney.DeserializeJson(ref reader, options);
          break;

        case "valuePeriod":
          ValuePeriod = new Fhir.R4.Models.Period();
          ValuePeriod.DeserializeJson(ref reader, options);
          break;

        case "valueQuantity":
          ValueQuantity = new Fhir.R4.Models.Quantity();
          ValueQuantity.DeserializeJson(ref reader, options);
          break;

        case "valueRange":
          ValueRange = new Fhir.R4.Models.Range();
          ValueRange.DeserializeJson(ref reader, options);
          break;

        case "valueRatio":
          ValueRatio = new Fhir.R4.Models.Ratio();
          ValueRatio.DeserializeJson(ref reader, options);
          break;

        case "valueReference":
          ValueReference = new Fhir.R4.Models.Reference();
          ValueReference.DeserializeJson(ref reader, options);
          break;

        case "valueSampledData":
          ValueSampledData = new Fhir.R4.Models.SampledData();
          ValueSampledData.DeserializeJson(ref reader, options);
          break;

        case "valueSignature":
          ValueSignature = new Fhir.R4.Models.Signature();
          ValueSignature.DeserializeJson(ref reader, options);
          break;

        case "valueTiming":
          ValueTiming = new Fhir.R4.Models.Timing();
          ValueTiming.DeserializeJson(ref reader, options);
          break;

        case "valueContactDetail":
          ValueContactDetail = new Fhir.R4.Models.ContactDetail();
          ValueContactDetail.DeserializeJson(ref reader, options);
          break;

        case "valueContributor":
          ValueContributor = new Fhir.R4.Models.Contributor();
          ValueContributor.DeserializeJson(ref reader, options);
          break;

        case "valueDataRequirement":
          ValueDataRequirement = new Fhir.R4.Models.DataRequirement();
          ValueDataRequirement.DeserializeJson(ref reader, options);
          break;

        case "valueExpression":
          ValueExpression = new Fhir.R4.Models.Expression();
          ValueExpression.DeserializeJson(ref reader, options);
          break;

        case "valueParameterDefinition":
          ValueParameterDefinition = new Fhir.R4.Models.ParameterDefinition();
          ValueParameterDefinition.DeserializeJson(ref reader, options);
          break;

        case "valueRelatedArtifact":
          ValueRelatedArtifact = new Fhir.R4.Models.RelatedArtifact();
          ValueRelatedArtifact.DeserializeJson(ref reader, options);
          break;

        case "valueTriggerDefinition":
          ValueTriggerDefinition = new Fhir.R4.Models.TriggerDefinition();
          ValueTriggerDefinition.DeserializeJson(ref reader, options);
          break;

        case "valueUsageContext":
          ValueUsageContext = new Fhir.R4.Models.UsageContext();
          ValueUsageContext.DeserializeJson(ref reader, options);
          break;

        case "valueDosage":
          ValueDosage = new Fhir.R4.Models.Dosage();
          ValueDosage.DeserializeJson(ref reader, options);
          break;

        case "valueMeta":
          ValueMeta = new Fhir.R4.Models.Meta();
          ValueMeta.DeserializeJson(ref reader, options);
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
  /// This resource is a non-persisted resource used to pass information into and back from an [operation](operations.html). It has no other use, and there is no RESTful endpoint associated with it.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class Parameters : Resource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Parameters";
    /// <summary>
    /// A parameter passed to or received from the operation.
    /// </summary>
    public List<ParametersParameter> Parameter { get; set; }
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


      ((Fhir.R4.Models.Resource)this).SerializeJson(ref writer, options, false);

      if ((Parameter != null) && (Parameter.Count != 0))
      {
        writer.WritePropertyName("parameter");
        writer.WriteStartArray();

        foreach (ParametersParameter valParameter in Parameter)
        {
          valParameter.SerializeJson(ref writer, options, true);
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
        case "parameter":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Parameter = new List<ParametersParameter>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ParametersParameter objParameter = new Fhir.R4.Models.ParametersParameter();
            objParameter.DeserializeJson(ref reader, options);
            Parameter.Add(objParameter);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Parameter.Count == 0)
          {
            Parameter = null;
          }

          break;

        default:
          ((Fhir.R4.Models.Resource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
