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
  /// Allows for adjustment on two axis.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<VisionPrescriptionLensSpecificationPrism>))]
  public class VisionPrescriptionLensSpecificationPrism : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Amount of prism to compensate for eye alignment in fractional units.
    /// </summary>
    public decimal Amount { get; set; }
    /// <summary>
    /// Extension container element for Amount
    /// </summary>
    public Element _Amount { get; set; }
    /// <summary>
    /// The relative base, or reference lens edge, for the prism.
    /// </summary>
    public string Base { get; set; }
    /// <summary>
    /// Extension container element for Base
    /// </summary>
    public Element _Base { get; set; }
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

      writer.WriteNumber("amount", Amount);

      if (_Amount != null)
      {
        writer.WritePropertyName("_amount");
        _Amount.SerializeJson(ref writer, options);
      }

      writer.WriteString("base", Base);

      if (_Base != null)
      {
        writer.WritePropertyName("_base");
        _Base.SerializeJson(ref writer, options);
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
        case "amount":
          Amount = reader.GetDecimal();
          break;

        case "_amount":
          _Amount = new Fhir.R4.Models.Element();
          _Amount.DeserializeJson(ref reader, options);
          break;

        case "base":
          Base = reader.GetString();
          break;

        case "_base":
          _Base = new Fhir.R4.Models.Element();
          _Base.DeserializeJson(ref reader, options);
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
  /// Contain the details of  the individual lens specifications and serves as the authorization for the fullfillment by certified professionals.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<VisionPrescriptionLensSpecification>))]
  public class VisionPrescriptionLensSpecification : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Power adjustment for multifocal lenses measured in dioptres (0.25 units).
    /// </summary>
    public decimal? Add { get; set; }
    /// <summary>
    /// Extension container element for Add
    /// </summary>
    public Element _Add { get; set; }
    /// <summary>
    /// The limits are +180 and -180 degrees.
    /// </summary>
    public int? Axis { get; set; }
    /// <summary>
    /// Back curvature measured in millimetres.
    /// </summary>
    public decimal? BackCurve { get; set; }
    /// <summary>
    /// Extension container element for BackCurve
    /// </summary>
    public Element _BackCurve { get; set; }
    /// <summary>
    /// Brand recommendations or restrictions.
    /// </summary>
    public string Brand { get; set; }
    /// <summary>
    /// Extension container element for Brand
    /// </summary>
    public Element _Brand { get; set; }
    /// <summary>
    /// Special color or pattern.
    /// </summary>
    public string Color { get; set; }
    /// <summary>
    /// Extension container element for Color
    /// </summary>
    public Element _Color { get; set; }
    /// <summary>
    /// Power adjustment for astigmatism measured in dioptres (0.25 units).
    /// </summary>
    public decimal? Cylinder { get; set; }
    /// <summary>
    /// Extension container element for Cylinder
    /// </summary>
    public Element _Cylinder { get; set; }
    /// <summary>
    /// Contact lens diameter measured in millimetres.
    /// </summary>
    public decimal? Diameter { get; set; }
    /// <summary>
    /// Extension container element for Diameter
    /// </summary>
    public Element _Diameter { get; set; }
    /// <summary>
    /// The recommended maximum wear period for the lens.
    /// </summary>
    public Quantity Duration { get; set; }
    /// <summary>
    /// May also appear as OD (oculus dexter) for the right eye and OS (oculus siniter) for the left eye.
    /// </summary>
    public string Eye { get; set; }
    /// <summary>
    /// Extension container element for Eye
    /// </summary>
    public Element _Eye { get; set; }
    /// <summary>
    /// Notes for special requirements such as coatings and lens materials.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// Contact lens power measured in dioptres (0.25 units).
    /// </summary>
    public decimal? Power { get; set; }
    /// <summary>
    /// Extension container element for Power
    /// </summary>
    public Element _Power { get; set; }
    /// <summary>
    /// Allows for adjustment on two axis.
    /// </summary>
    public List<VisionPrescriptionLensSpecificationPrism> Prism { get; set; }
    /// <summary>
    /// Identifies the type of vision correction product which is required for the patient.
    /// </summary>
    public CodeableConcept Product { get; set; }
    /// <summary>
    /// The value is negative for near-sighted and positive for far sighted.
    /// Often insurance will not cover a lens with power between +75 and -75.
    /// </summary>
    public decimal? Sphere { get; set; }
    /// <summary>
    /// Extension container element for Sphere
    /// </summary>
    public Element _Sphere { get; set; }
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

      if (Add != null)
      {
        writer.WriteNumber("add", (decimal)Add!);
      }

      if (_Add != null)
      {
        writer.WritePropertyName("_add");
        _Add.SerializeJson(ref writer, options);
      }

      if (Axis != null)
      {
        writer.WriteNumber("axis", (int)Axis!);
      }

      if (BackCurve != null)
      {
        writer.WriteNumber("backCurve", (decimal)BackCurve!);
      }

      if (_BackCurve != null)
      {
        writer.WritePropertyName("_backCurve");
        _BackCurve.SerializeJson(ref writer, options);
      }

      writer.WriteString("brand", Brand);

      if (_Brand != null)
      {
        writer.WritePropertyName("_brand");
        _Brand.SerializeJson(ref writer, options);
      }

      writer.WriteString("color", Color);

      if (_Color != null)
      {
        writer.WritePropertyName("_color");
        _Color.SerializeJson(ref writer, options);
      }

      if (Cylinder != null)
      {
        writer.WriteNumber("cylinder", (decimal)Cylinder!);
      }

      if (_Cylinder != null)
      {
        writer.WritePropertyName("_cylinder");
        _Cylinder.SerializeJson(ref writer, options);
      }

      if (Diameter != null)
      {
        writer.WriteNumber("diameter", (decimal)Diameter!);
      }

      if (_Diameter != null)
      {
        writer.WritePropertyName("_diameter");
        _Diameter.SerializeJson(ref writer, options);
      }

      if (Duration != null)
      {
        writer.WritePropertyName("duration");
        Duration.SerializeJson(ref writer, options);
      }

      writer.WriteString("eye", Eye);

      if (_Eye != null)
      {
        writer.WritePropertyName("_eye");
        _Eye.SerializeJson(ref writer, options);
      }

      if ((Note != null) && (Note.Count != 0))
      {
        writer.WritePropertyName("note");
        writer.WriteStartArray();

        foreach (Annotation valNote in Note)
        {
          valNote.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Power != null)
      {
        writer.WriteNumber("power", (decimal)Power!);
      }

      if (_Power != null)
      {
        writer.WritePropertyName("_power");
        _Power.SerializeJson(ref writer, options);
      }

      if ((Prism != null) && (Prism.Count != 0))
      {
        writer.WritePropertyName("prism");
        writer.WriteStartArray();

        foreach (VisionPrescriptionLensSpecificationPrism valPrism in Prism)
        {
          valPrism.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WritePropertyName("product");
      Product.SerializeJson(ref writer, options);

      if (Sphere != null)
      {
        writer.WriteNumber("sphere", (decimal)Sphere!);
      }

      if (_Sphere != null)
      {
        writer.WritePropertyName("_sphere");
        _Sphere.SerializeJson(ref writer, options);
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
        case "add":
          Add = reader.GetDecimal();
          break;

        case "_add":
          _Add = new Fhir.R4.Models.Element();
          _Add.DeserializeJson(ref reader, options);
          break;

        case "axis":
          Axis = reader.GetInt32();
          break;

        case "backCurve":
          BackCurve = reader.GetDecimal();
          break;

        case "_backCurve":
          _BackCurve = new Fhir.R4.Models.Element();
          _BackCurve.DeserializeJson(ref reader, options);
          break;

        case "brand":
          Brand = reader.GetString();
          break;

        case "_brand":
          _Brand = new Fhir.R4.Models.Element();
          _Brand.DeserializeJson(ref reader, options);
          break;

        case "color":
          Color = reader.GetString();
          break;

        case "_color":
          _Color = new Fhir.R4.Models.Element();
          _Color.DeserializeJson(ref reader, options);
          break;

        case "cylinder":
          Cylinder = reader.GetDecimal();
          break;

        case "_cylinder":
          _Cylinder = new Fhir.R4.Models.Element();
          _Cylinder.DeserializeJson(ref reader, options);
          break;

        case "diameter":
          Diameter = reader.GetDecimal();
          break;

        case "_diameter":
          _Diameter = new Fhir.R4.Models.Element();
          _Diameter.DeserializeJson(ref reader, options);
          break;

        case "duration":
          Duration = new Fhir.R4.Models.Quantity();
          Duration.DeserializeJson(ref reader, options);
          break;

        case "eye":
          Eye = reader.GetString();
          break;

        case "_eye":
          _Eye = new Fhir.R4.Models.Element();
          _Eye.DeserializeJson(ref reader, options);
          break;

        case "note":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Note = new List<Annotation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Annotation objNote = new Fhir.R4.Models.Annotation();
            objNote.DeserializeJson(ref reader, options);
            Note.Add(objNote);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Note.Count == 0)
          {
            Note = null;
          }

          break;

        case "power":
          Power = reader.GetDecimal();
          break;

        case "_power":
          _Power = new Fhir.R4.Models.Element();
          _Power.DeserializeJson(ref reader, options);
          break;

        case "prism":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Prism = new List<VisionPrescriptionLensSpecificationPrism>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.VisionPrescriptionLensSpecificationPrism objPrism = new Fhir.R4.Models.VisionPrescriptionLensSpecificationPrism();
            objPrism.DeserializeJson(ref reader, options);
            Prism.Add(objPrism);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Prism.Count == 0)
          {
            Prism = null;
          }

          break;

        case "product":
          Product = new Fhir.R4.Models.CodeableConcept();
          Product.DeserializeJson(ref reader, options);
          break;

        case "sphere":
          Sphere = reader.GetDecimal();
          break;

        case "_sphere":
          _Sphere = new Fhir.R4.Models.Element();
          _Sphere.DeserializeJson(ref reader, options);
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
  /// An authorization for the provision of glasses and/or contact lenses to a patient.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class VisionPrescription : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "VisionPrescription";
    /// <summary>
    /// The date this resource was created.
    /// </summary>
    public string Created { get; set; }
    /// <summary>
    /// Extension container element for Created
    /// </summary>
    public Element _Created { get; set; }
    /// <summary>
    /// Jurisdictions determine the valid lifetime of a prescription. Typically vision prescriptions are valid for two years from the date written.
    /// </summary>
    public string DateWritten { get; set; }
    /// <summary>
    /// Extension container element for DateWritten
    /// </summary>
    public Element _DateWritten { get; set; }
    /// <summary>
    /// A reference to a resource that identifies the particular occurrence of contact between patient and health care provider during which the prescription was issued.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// A unique identifier assigned to this vision prescription.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Contain the details of  the individual lens specifications and serves as the authorization for the fullfillment by certified professionals.
    /// </summary>
    public List<VisionPrescriptionLensSpecification> LensSpecification { get; set; }
    /// <summary>
    /// A resource reference to the person to whom the vision prescription applies.
    /// </summary>
    public Reference Patient { get; set; }
    /// <summary>
    /// The healthcare professional responsible for authorizing the prescription.
    /// </summary>
    public Reference Prescriber { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
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

      writer.WriteString("dateWritten", DateWritten);

      if (_DateWritten != null)
      {
        writer.WritePropertyName("_dateWritten");
        _DateWritten.SerializeJson(ref writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(ref writer, options);
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

      if ((LensSpecification != null) && (LensSpecification.Count != 0))
      {
        writer.WritePropertyName("lensSpecification");
        writer.WriteStartArray();

        foreach (VisionPrescriptionLensSpecification valLensSpecification in LensSpecification)
        {
          valLensSpecification.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WritePropertyName("patient");
      Patient.SerializeJson(ref writer, options);

      writer.WritePropertyName("prescriber");
      Prescriber.SerializeJson(ref writer, options);

      writer.WriteString("status", Status);

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(ref writer, options);
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

        case "dateWritten":
          DateWritten = reader.GetString();
          break;

        case "_dateWritten":
          _DateWritten = new Fhir.R4.Models.Element();
          _DateWritten.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new Fhir.R4.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
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

        case "lensSpecification":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          LensSpecification = new List<VisionPrescriptionLensSpecification>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.VisionPrescriptionLensSpecification objLensSpecification = new Fhir.R4.Models.VisionPrescriptionLensSpecification();
            objLensSpecification.DeserializeJson(ref reader, options);
            LensSpecification.Add(objLensSpecification);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (LensSpecification.Count == 0)
          {
            LensSpecification = null;
          }

          break;

        case "patient":
          Patient = new Fhir.R4.Models.Reference();
          Patient.DeserializeJson(ref reader, options);
          break;

        case "prescriber":
          Prescriber = new Fhir.R4.Models.Reference();
          Prescriber.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
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
