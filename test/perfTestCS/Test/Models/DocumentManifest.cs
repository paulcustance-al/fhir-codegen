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
  /// May be identifiers or resources that caused the DocumentManifest to be created.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<DocumentManifestRelated>))]
  public class DocumentManifestRelated : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// If both identifier and ref elements are present they shall refer to the same thing.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// If both identifier and ref elements are present they shall refer to the same thing.
    /// </summary>
    public Reference Ref { get; set; }
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

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(ref writer, options);
      }

      if (Ref != null)
      {
        writer.WritePropertyName("ref");
        Ref.SerializeJson(ref writer, options);
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
        case "identifier":
          Identifier = new Fhir.R4.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "ref":
          Ref = new Fhir.R4.Models.Reference();
          Ref.DeserializeJson(ref reader, options);
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
  /// A collection of documents compiled for a purpose together with metadata that applies to the collection.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class DocumentManifest : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "DocumentManifest";
    /// <summary>
    /// Not necessarily who did the actual data entry (i.e. typist) or who was the source (informant).
    /// </summary>
    public List<Reference> Author { get; set; }
    /// <summary>
    /// When used for XDS the intended focus of the DocumentManifest is for the reference to target to be a set of DocumentReference Resources. The reference is to "Any" to support EN 13606 usage, where an extract is DocumentManifest that references  List and Composition resources.
    /// </summary>
    public List<Reference> Content { get; set; }
    /// <summary>
    /// Creation time is used for tracking, organizing versions and searching. This is the creation time of the document set, not the documents on which it is based.
    /// </summary>
    public string Created { get; set; }
    /// <summary>
    /// Extension container element for Created
    /// </summary>
    public Element _Created { get; set; }
    /// <summary>
    /// What the document is about, rather than a terse summary of the document. It is commonly the case that records do not have a title and are collectively referred to by the display name of Record code (e.g. a "consultation" or "progress note").
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// Other identifiers associated with the document manifest, including version independent  identifiers.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// A single identifier that uniquely identifies this manifest. Principally used to refer to the manifest in non-FHIR contexts.
    /// </summary>
    public Identifier MasterIdentifier { get; set; }
    /// <summary>
    /// How the recipient receives the document set or is notified of it is up to the implementation. This element is just a statement of intent. If the recipient is a person, and it is not known whether the person is a patient or a practitioner, RelatedPerson would be the default choice.
    /// </summary>
    public List<Reference> Recipient { get; set; }
    /// <summary>
    /// May be identifiers or resources that caused the DocumentManifest to be created.
    /// </summary>
    public List<DocumentManifestRelated> Related { get; set; }
    /// <summary>
    /// Identifies the source system, application, or software that produced the document manifest.
    /// </summary>
    public string Source { get; set; }
    /// <summary>
    /// Extension container element for Source
    /// </summary>
    public Element _Source { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains the codes that mark the manifest as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Who or what the set of documents is about. The documents can be about a person, (patient or healthcare practitioner), a device (i.e. machine) or even a group of subjects (such as a document about a herd of farm animals, or a set of patients that share a common exposure). If the documents cross more than one subject, then more than one subject is allowed here (unusual use case).
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Specifies the kind of this set of documents (e.g. Patient Summary, Discharge Summary, Prescription, etc.). The type of a set of documents may be the same as one of the documents in it - especially if there is only one - but it may be wider.
    /// </summary>
    public CodeableConcept Type { get; set; }
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

      if ((Author != null) && (Author.Count != 0))
      {
        writer.WritePropertyName("author");
        writer.WriteStartArray();

        foreach (Reference valAuthor in Author)
        {
          valAuthor.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Content != null) && (Content.Count != 0))
      {
        writer.WritePropertyName("content");
        writer.WriteStartArray();

        foreach (Reference valContent in Content)
        {
          valContent.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("created", Created);

      if (_Created != null)
      {
        writer.WritePropertyName("_created");
        _Created.SerializeJson(ref writer, options);
      }

      writer.WriteString("description", Description);

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(ref writer, options);
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

      if (MasterIdentifier != null)
      {
        writer.WritePropertyName("masterIdentifier");
        MasterIdentifier.SerializeJson(ref writer, options);
      }

      if ((Recipient != null) && (Recipient.Count != 0))
      {
        writer.WritePropertyName("recipient");
        writer.WriteStartArray();

        foreach (Reference valRecipient in Recipient)
        {
          valRecipient.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Related != null) && (Related.Count != 0))
      {
        writer.WritePropertyName("related");
        writer.WriteStartArray();

        foreach (DocumentManifestRelated valRelated in Related)
        {
          valRelated.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("source", Source);

      if (_Source != null)
      {
        writer.WritePropertyName("_source");
        _Source.SerializeJson(ref writer, options);
      }

      writer.WriteString("status", Status);

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(ref writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(ref writer, options);
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(ref writer, options);
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
        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Author = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objAuthor = new Fhir.R4.Models.Reference();
            objAuthor.DeserializeJson(ref reader, options);
            Author.Add(objAuthor);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Author.Count == 0)
          {
            Author = null;
          }

          break;

        case "content":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Content = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objContent = new Fhir.R4.Models.Reference();
            objContent.DeserializeJson(ref reader, options);
            Content.Add(objContent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Content.Count == 0)
          {
            Content = null;
          }

          break;

        case "created":
          Created = reader.GetString();
          break;

        case "_created":
          _Created = new Fhir.R4.Models.Element();
          _Created.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new Fhir.R4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
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

        case "masterIdentifier":
          MasterIdentifier = new Fhir.R4.Models.Identifier();
          MasterIdentifier.DeserializeJson(ref reader, options);
          break;

        case "recipient":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Recipient = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objRecipient = new Fhir.R4.Models.Reference();
            objRecipient.DeserializeJson(ref reader, options);
            Recipient.Add(objRecipient);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Recipient.Count == 0)
          {
            Recipient = null;
          }

          break;

        case "related":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Related = new List<DocumentManifestRelated>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.DocumentManifestRelated objRelated = new Fhir.R4.Models.DocumentManifestRelated();
            objRelated.DeserializeJson(ref reader, options);
            Related.Add(objRelated);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Related.Count == 0)
          {
            Related = null;
          }

          break;

        case "source":
          Source = reader.GetString();
          break;

        case "_source":
          _Source = new Fhir.R4.Models.Element();
          _Source.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new Fhir.R4.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = new Fhir.R4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
