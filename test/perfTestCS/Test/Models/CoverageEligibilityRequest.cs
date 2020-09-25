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
  /// Often there are multiple jurisdiction specific valuesets which are required.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<CoverageEligibilityRequestSupportingInfo>))]
  public class CoverageEligibilityRequestSupportingInfo : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The supporting materials are applicable for all detail items, product/servce categories and specific billing codes.
    /// </summary>
    public bool? AppliesToAll { get; set; }
    /// <summary>
    /// Could be used to provide references to other resources, document. For example could contain a PDF in an Attachment of the Police Report for an Accident.
    /// </summary>
    public Reference Information { get; set; }
    /// <summary>
    /// A number to uniquely identify supporting information entries.
    /// </summary>
    public uint Sequence { get; set; }
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

      if (AppliesToAll != null)
      {
        writer.WriteBoolean("appliesToAll", (bool)AppliesToAll!);
      }

      writer.WritePropertyName("information");
      Information.SerializeJson(ref writer, options);

      writer.WriteNumber("sequence", Sequence);

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
        case "appliesToAll":
          AppliesToAll = reader.GetBoolean();
          break;

        case "information":
          Information = new Fhir.R4.Models.Reference();
          Information.DeserializeJson(ref reader, options);
          break;

        case "sequence":
          Sequence = reader.GetUInt32();
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
  /// All insurance coverages for the patient which may be applicable for reimbursement, of the products and services listed in the claim, are typically provided in the claim to allow insurers to confirm the ordering of the insurance coverages relative to local 'coordination of benefit' rules. One coverage (and only one) with 'focal=true' is to be used in the adjudication of this claim. Coverages appearing before the focal Coverage in the list, and where 'subrogation=false', should provide a reference to the ClaimResponse containing the adjudication results of the prior claim.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<CoverageEligibilityRequestInsurance>))]
  public class CoverageEligibilityRequestInsurance : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A business agreement number established between the provider and the insurer for special business processing purposes.
    /// </summary>
    public string BusinessArrangement { get; set; }
    /// <summary>
    /// Extension container element for BusinessArrangement
    /// </summary>
    public Element _BusinessArrangement { get; set; }
    /// <summary>
    /// Reference to the insurance card level information contained in the Coverage resource. The coverage issuing insurer will use these details to locate the patient's actual coverage within the insurer's information system.
    /// </summary>
    public Reference Coverage { get; set; }
    /// <summary>
    /// A patient may (will) have multiple insurance policies which provide reimburement for healthcare services and products. For example a person may also be covered by their spouse's policy and both appear in the list (and may be from the same insurer). This flag will be set to true for only one of the listed policies and that policy will be used for evaluating this request. Other requests would be created to request evaluation against the other listed policies.
    /// </summary>
    public bool? Focal { get; set; }
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

      writer.WriteString("businessArrangement", BusinessArrangement);

      if (_BusinessArrangement != null)
      {
        writer.WritePropertyName("_businessArrangement");
        _BusinessArrangement.SerializeJson(ref writer, options);
      }

      writer.WritePropertyName("coverage");
      Coverage.SerializeJson(ref writer, options);

      if (Focal != null)
      {
        writer.WriteBoolean("focal", (bool)Focal!);
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
        case "businessArrangement":
          BusinessArrangement = reader.GetString();
          break;

        case "_businessArrangement":
          _BusinessArrangement = new Fhir.R4.Models.Element();
          _BusinessArrangement.DeserializeJson(ref reader, options);
          break;

        case "coverage":
          Coverage = new Fhir.R4.Models.Reference();
          Coverage.DeserializeJson(ref reader, options);
          break;

        case "focal":
          Focal = reader.GetBoolean();
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
  /// Patient diagnosis for which care is sought.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<CoverageEligibilityRequestItemDiagnosis>))]
  public class CoverageEligibilityRequestItemDiagnosis : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The nature of illness or problem in a coded form or as a reference to an external defined Condition.
    /// </summary>
    public CodeableConcept DiagnosisCodeableConcept { get; set; }
    /// <summary>
    /// The nature of illness or problem in a coded form or as a reference to an external defined Condition.
    /// </summary>
    public Reference DiagnosisReference { get; set; }
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

      if (DiagnosisCodeableConcept != null)
      {
        writer.WritePropertyName("diagnosisCodeableConcept");
        DiagnosisCodeableConcept.SerializeJson(ref writer, options);
      }

      if (DiagnosisReference != null)
      {
        writer.WritePropertyName("diagnosisReference");
        DiagnosisReference.SerializeJson(ref writer, options);
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
        case "diagnosisCodeableConcept":
          DiagnosisCodeableConcept = new Fhir.R4.Models.CodeableConcept();
          DiagnosisCodeableConcept.DeserializeJson(ref reader, options);
          break;

        case "diagnosisReference":
          DiagnosisReference = new Fhir.R4.Models.Reference();
          DiagnosisReference.DeserializeJson(ref reader, options);
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
  /// Service categories or billable services for which benefit details and/or an authorization prior to service delivery may be required by the payor.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<CoverageEligibilityRequestItem>))]
  public class CoverageEligibilityRequestItem : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Examples include Medical Care, Periodontics, Renal Dialysis, Vision Coverage.
    /// </summary>
    public CodeableConcept Category { get; set; }
    /// <summary>
    /// The plan/proposal/order describing the proposed service in detail.
    /// </summary>
    public List<Reference> Detail { get; set; }
    /// <summary>
    /// Patient diagnosis for which care is sought.
    /// </summary>
    public List<CoverageEligibilityRequestItemDiagnosis> Diagnosis { get; set; }
    /// <summary>
    /// Facility where the services will be provided.
    /// </summary>
    public Reference Facility { get; set; }
    /// <summary>
    /// For example in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or out of office hours.
    /// </summary>
    public List<CodeableConcept> Modifier { get; set; }
    /// <summary>
    /// Code to indicate the Professional Service or Product supplied (e.g. CTP, HCPCS, USCLS, ICD10, NCPDP, DIN, RxNorm, ACHI, CCI).
    /// </summary>
    public CodeableConcept ProductOrService { get; set; }
    /// <summary>
    /// The practitioner who is responsible for the product or service to be rendered to the patient.
    /// </summary>
    public Reference Provider { get; set; }
    /// <summary>
    /// The number of repetitions of a service or product.
    /// </summary>
    public Quantity Quantity { get; set; }
    /// <summary>
    /// Exceptions, special conditions and supporting information applicable for this service or product line.
    /// </summary>
    public List<uint> SupportingInfoSequence { get; set; }
    /// <summary>
    /// The amount charged to the patient by the provider for a single unit.
    /// </summary>
    public Money UnitPrice { get; set; }
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

      if (Category != null)
      {
        writer.WritePropertyName("category");
        Category.SerializeJson(ref writer, options);
      }

      if ((Detail != null) && (Detail.Count != 0))
      {
        writer.WritePropertyName("detail");
        writer.WriteStartArray();

        foreach (Reference valDetail in Detail)
        {
          valDetail.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Diagnosis != null) && (Diagnosis.Count != 0))
      {
        writer.WritePropertyName("diagnosis");
        writer.WriteStartArray();

        foreach (CoverageEligibilityRequestItemDiagnosis valDiagnosis in Diagnosis)
        {
          valDiagnosis.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Facility != null)
      {
        writer.WritePropertyName("facility");
        Facility.SerializeJson(ref writer, options);
      }

      if ((Modifier != null) && (Modifier.Count != 0))
      {
        writer.WritePropertyName("modifier");
        writer.WriteStartArray();

        foreach (CodeableConcept valModifier in Modifier)
        {
          valModifier.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (ProductOrService != null)
      {
        writer.WritePropertyName("productOrService");
        ProductOrService.SerializeJson(ref writer, options);
      }

      if (Provider != null)
      {
        writer.WritePropertyName("provider");
        Provider.SerializeJson(ref writer, options);
      }

      if (Quantity != null)
      {
        writer.WritePropertyName("quantity");
        Quantity.SerializeJson(ref writer, options);
      }

      if ((SupportingInfoSequence != null) && (SupportingInfoSequence.Count != 0))
      {
        writer.WritePropertyName("supportingInfoSequence");
        writer.WriteStartArray();

        foreach (uint valSupportingInfoSequence in SupportingInfoSequence)
        {
          writer.WriteNumberValue(valSupportingInfoSequence);
        }

        writer.WriteEndArray();
      }

      if (UnitPrice != null)
      {
        writer.WritePropertyName("unitPrice");
        UnitPrice.SerializeJson(ref writer, options);
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
        case "category":
          Category = new Fhir.R4.Models.CodeableConcept();
          Category.DeserializeJson(ref reader, options);
          break;

        case "detail":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Detail = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objDetail = new Fhir.R4.Models.Reference();
            objDetail.DeserializeJson(ref reader, options);
            Detail.Add(objDetail);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Detail.Count == 0)
          {
            Detail = null;
          }

          break;

        case "diagnosis":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Diagnosis = new List<CoverageEligibilityRequestItemDiagnosis>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CoverageEligibilityRequestItemDiagnosis objDiagnosis = new Fhir.R4.Models.CoverageEligibilityRequestItemDiagnosis();
            objDiagnosis.DeserializeJson(ref reader, options);
            Diagnosis.Add(objDiagnosis);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Diagnosis.Count == 0)
          {
            Diagnosis = null;
          }

          break;

        case "facility":
          Facility = new Fhir.R4.Models.Reference();
          Facility.DeserializeJson(ref reader, options);
          break;

        case "modifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Modifier = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objModifier = new Fhir.R4.Models.CodeableConcept();
            objModifier.DeserializeJson(ref reader, options);
            Modifier.Add(objModifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Modifier.Count == 0)
          {
            Modifier = null;
          }

          break;

        case "productOrService":
          ProductOrService = new Fhir.R4.Models.CodeableConcept();
          ProductOrService.DeserializeJson(ref reader, options);
          break;

        case "provider":
          Provider = new Fhir.R4.Models.Reference();
          Provider.DeserializeJson(ref reader, options);
          break;

        case "quantity":
          Quantity = new Fhir.R4.Models.Quantity();
          Quantity.DeserializeJson(ref reader, options);
          break;

        case "supportingInfoSequence":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SupportingInfoSequence = new List<uint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            SupportingInfoSequence.Add(reader.GetUInt32());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SupportingInfoSequence.Count == 0)
          {
            SupportingInfoSequence = null;
          }

          break;

        case "unitPrice":
          UnitPrice = new Fhir.R4.Models.Money();
          UnitPrice.DeserializeJson(ref reader, options);
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
  /// The CoverageEligibilityRequest provides patient and insurance coverage information to an insurer for them to respond, in the form of an CoverageEligibilityResponse, with information regarding whether the stated coverage is valid and in-force and optionally to provide the insurance details of the policy.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class CoverageEligibilityRequest : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "CoverageEligibilityRequest";
    /// <summary>
    /// The date when this resource was created.
    /// </summary>
    public string Created { get; set; }
    /// <summary>
    /// Extension container element for Created
    /// </summary>
    public Element _Created { get; set; }
    /// <summary>
    /// Person who created the request.
    /// </summary>
    public Reference Enterer { get; set; }
    /// <summary>
    /// Facility where the services are intended to be provided.
    /// </summary>
    public Reference Facility { get; set; }
    /// <summary>
    /// A unique identifier assigned to this coverage eligiblity request.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// All insurance coverages for the patient which may be applicable for reimbursement, of the products and services listed in the claim, are typically provided in the claim to allow insurers to confirm the ordering of the insurance coverages relative to local 'coordination of benefit' rules. One coverage (and only one) with 'focal=true' is to be used in the adjudication of this claim. Coverages appearing before the focal Coverage in the list, and where 'subrogation=false', should provide a reference to the ClaimResponse containing the adjudication results of the prior claim.
    /// </summary>
    public List<CoverageEligibilityRequestInsurance> Insurance { get; set; }
    /// <summary>
    /// The Insurer who issued the coverage in question and is the recipient of the request.
    /// </summary>
    public Reference Insurer { get; set; }
    /// <summary>
    /// Service categories or billable services for which benefit details and/or an authorization prior to service delivery may be required by the payor.
    /// </summary>
    public List<CoverageEligibilityRequestItem> Item { get; set; }
    /// <summary>
    /// 1..1.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// When the requestor expects the processor to complete processing.
    /// </summary>
    public CodeableConcept Priority { get; set; }
    /// <summary>
    /// Typically this field would be 1..1 where this party is responsible for the eligibility request but not necessarily professionally responsible for the provision of the individual products and services listed below.
    /// </summary>
    public Reference Provider { get; set; }
    /// <summary>
    /// Code to specify whether requesting: prior authorization requirements for some service categories or billing codes; benefits for coverages specified or discovered; discovery and return of coverages for the patient; and/or validation that the specified coverage is in-force at the date/period specified or 'now' if not specified.
    /// </summary>
    public List<string> Purpose { get; set; }
    /// <summary>
    /// Extension container element for Purpose
    /// </summary>
    public List<Element> _Purpose { get; set; }
    /// <summary>
    /// The date or dates when the enclosed suite of services were performed or completed.
    /// </summary>
    public string ServicedDate { get; set; }
    /// <summary>
    /// Extension container element for ServicedDate
    /// </summary>
    public Element _ServicedDate { get; set; }
    /// <summary>
    /// The date or dates when the enclosed suite of services were performed or completed.
    /// </summary>
    public Period ServicedPeriod { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Often there are multiple jurisdiction specific valuesets which are required.
    /// </summary>
    public List<CoverageEligibilityRequestSupportingInfo> SupportingInfo { get; set; }
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

      writer.WriteString("created", Created);

      if (_Created != null)
      {
        writer.WritePropertyName("_created");
        _Created.SerializeJson(ref writer, options);
      }

      if (Enterer != null)
      {
        writer.WritePropertyName("enterer");
        Enterer.SerializeJson(ref writer, options);
      }

      if (Facility != null)
      {
        writer.WritePropertyName("facility");
        Facility.SerializeJson(ref writer, options);
      }

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Insurance != null) && (Insurance.Count != 0))
      {
        writer.WritePropertyName("insurance");
        writer.WriteStartArray();

        foreach (CoverageEligibilityRequestInsurance valInsurance in Insurance)
        {
          valInsurance.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WritePropertyName("insurer");
      Insurer.SerializeJson(ref writer, options);

      if ((Item != null) && (Item.Count != 0))
      {
        writer.WritePropertyName("item");
        writer.WriteStartArray();

        foreach (CoverageEligibilityRequestItem valItem in Item)
        {
          valItem.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WritePropertyName("patient");
      Patient.SerializeJson(ref writer, options);

      if (Priority != null)
      {
        writer.WritePropertyName("priority");
        Priority.SerializeJson(ref writer, options);
      }

      if (Provider != null)
      {
        writer.WritePropertyName("provider");
        Provider.SerializeJson(ref writer, options);
      }

      if ((Purpose != null) && (Purpose.Count != 0))
      {
        writer.WritePropertyName("purpose");
        writer.WriteStartArray();

        foreach (string valPurpose in Purpose)
        {
          writer.WriteStringValue(valPurpose);
        }

        writer.WriteEndArray();
      }

      if ((_Purpose != null) && (_Purpose.Count != 0))
      {
        writer.WritePropertyName("_purpose");
        writer.WriteStartArray();

        foreach (Element val_Purpose in _Purpose)
        {
          val_Purpose.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("servicedDate", ServicedDate);

      if (_ServicedDate != null)
      {
        writer.WritePropertyName("_servicedDate");
        _ServicedDate.SerializeJson(ref writer, options);
      }

      if (ServicedPeriod != null)
      {
        writer.WritePropertyName("servicedPeriod");
        ServicedPeriod.SerializeJson(ref writer, options);
      }

      writer.WriteString("status", Status);

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(ref writer, options);
      }

      if ((SupportingInfo != null) && (SupportingInfo.Count != 0))
      {
        writer.WritePropertyName("supportingInfo");
        writer.WriteStartArray();

        foreach (CoverageEligibilityRequestSupportingInfo valSupportingInfo in SupportingInfo)
        {
          valSupportingInfo.SerializeJson(ref writer, options, true);
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
        case "created":
          Created = reader.GetString();
          break;

        case "_created":
          _Created = new Fhir.R4.Models.Element();
          _Created.DeserializeJson(ref reader, options);
          break;

        case "enterer":
          Enterer = new Fhir.R4.Models.Reference();
          Enterer.DeserializeJson(ref reader, options);
          break;

        case "facility":
          Facility = new Fhir.R4.Models.Reference();
          Facility.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Identifier objIdentifier = new Fhir.R4.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "insurance":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Insurance = new List<CoverageEligibilityRequestInsurance>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CoverageEligibilityRequestInsurance objInsurance = new Fhir.R4.Models.CoverageEligibilityRequestInsurance();
            objInsurance.DeserializeJson(ref reader, options);
            Insurance.Add(objInsurance);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Insurance.Count == 0)
          {
            Insurance = null;
          }

          break;

        case "insurer":
          Insurer = new Fhir.R4.Models.Reference();
          Insurer.DeserializeJson(ref reader, options);
          break;

        case "item":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Item = new List<CoverageEligibilityRequestItem>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CoverageEligibilityRequestItem objItem = new Fhir.R4.Models.CoverageEligibilityRequestItem();
            objItem.DeserializeJson(ref reader, options);
            Item.Add(objItem);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Item.Count == 0)
          {
            Item = null;
          }

          break;

        case "patient":
          Patient = new Fhir.R4.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "priority":
          Priority = new Fhir.R4.Models.CodeableConcept();
          Priority.DeserializeJson(ref reader, options);
          break;

        case "provider":
          Provider = new Fhir.R4.Models.Reference();
          Provider.DeserializeJson(ref reader, options);
          break;

        case "purpose":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Purpose = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Purpose.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Purpose.Count == 0)
          {
            Purpose = null;
          }

          break;

        case "_purpose":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Purpose = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_Purpose = new Fhir.R4.Models.Element();
            obj_Purpose.DeserializeJson(ref reader, options);
            _Purpose.Add(obj_Purpose);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Purpose.Count == 0)
          {
            _Purpose = null;
          }

          break;

        case "servicedDate":
          ServicedDate = reader.GetString();
          break;

        case "_servicedDate":
          _ServicedDate = new Fhir.R4.Models.Element();
          _ServicedDate.DeserializeJson(ref reader, options);
          break;

        case "servicedPeriod":
          ServicedPeriod = new Fhir.R4.Models.Period();
          ServicedPeriod.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "supportingInfo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SupportingInfo = new List<CoverageEligibilityRequestSupportingInfo>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CoverageEligibilityRequestSupportingInfo objSupportingInfo = new Fhir.R4.Models.CoverageEligibilityRequestSupportingInfo();
            objSupportingInfo.DeserializeJson(ref reader, options);
            SupportingInfo.Add(objSupportingInfo);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SupportingInfo.Count == 0)
          {
            SupportingInfo = null;
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
