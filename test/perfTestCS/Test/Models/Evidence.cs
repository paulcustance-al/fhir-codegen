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
  /// The Evidence resource describes the conditional state (population and any exposures being compared within the population) and outcome (if specified) that the knowledge (evidence, assertion, recommendation) is about.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class Evidence : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Evidence";
    /// <summary>
    /// The 'date' element may be more recent than the approval date because of minor changes or editorial corrections.
    /// </summary>
    public string ApprovalDate { get; set; }
    /// <summary>
    /// Extension container element for ApprovalDate
    /// </summary>
    public Element _ApprovalDate { get; set; }
    /// <summary>
    /// An individiual or organization primarily involved in the creation and maintenance of the content.
    /// </summary>
    public List<ContactDetail> Author { get; set; }
    /// <summary>
    /// May be a web site, an email address, a telephone number, etc.
    /// </summary>
    public List<ContactDetail> Contact { get; set; }
    /// <summary>
    /// A copyright statement relating to the evidence and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the evidence.
    /// </summary>
    public string Copyright { get; set; }
    /// <summary>
    /// Extension container element for Copyright
    /// </summary>
    public Element _Copyright { get; set; }
    /// <summary>
    /// Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the evidence. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// This description can be used to capture details such as why the evidence was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the evidence as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the evidence is presumed to be the predominant language in the place the evidence was created).
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// An individual or organization primarily responsible for internal coherence of the content.
    /// </summary>
    public List<ContactDetail> Editor { get; set; }
    /// <summary>
    /// The effective period for a evidence  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.
    /// </summary>
    public Period EffectivePeriod { get; set; }
    /// <summary>
    /// An individual or organization responsible for officially endorsing the content for use in some setting.
    /// </summary>
    public List<ContactDetail> Endorser { get; set; }
    /// <summary>
    /// A reference to a EvidenceVariable resource that defines the population for the research.
    /// </summary>
    public Reference ExposureBackground { get; set; }
    /// <summary>
    /// A reference to a EvidenceVariable resource that defines the exposure for the research.
    /// </summary>
    public List<Reference> ExposureVariant { get; set; }
    /// <summary>
    /// Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this evidence outside of FHIR, where it is not possible to use the logical URI.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// It may be possible for the evidence to be used in jurisdictions other than those for which it was originally designed or intended.
    /// </summary>
    public List<CodeableConcept> Jurisdiction { get; set; }
    /// <summary>
    /// If specified, this date follows the original approval date.
    /// </summary>
    public string LastReviewDate { get; set; }
    /// <summary>
    /// Extension container element for LastReviewDate
    /// </summary>
    public Element _LastReviewDate { get; set; }
    /// <summary>
    /// The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// A human-readable string to clarify or explain concepts about the resource.
    /// </summary>
    public List<Annotation> Note { get; set; }
    /// <summary>
    /// A reference to a EvidenceVariable resomece that defines the outcome for the research.
    /// </summary>
    public List<Reference> Outcome { get; set; }
    /// <summary>
    /// Usually an organization but may be an individual. The publisher (or steward) of the evidence is the organization or individual primarily responsible for the maintenance and upkeep of the evidence. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the evidence. This item SHOULD be populated unless the information is available from context.
    /// </summary>
    public string Publisher { get; set; }
    /// <summary>
    /// Extension container element for Publisher
    /// </summary>
    public Element _Publisher { get; set; }
    /// <summary>
    /// Each related artifact is either an attachment, or a reference to another resource, but not both.
    /// </summary>
    public List<RelatedArtifact> RelatedArtifact { get; set; }
    /// <summary>
    /// An individual or organization primarily responsible for review of some aspect of the content.
    /// </summary>
    public List<ContactDetail> Reviewer { get; set; }
    /// <summary>
    /// The short title provides an alternate title for use in informal descriptive contexts where the full, formal title is not necessary.
    /// </summary>
    public string ShortTitle { get; set; }
    /// <summary>
    /// Extension container element for ShortTitle
    /// </summary>
    public Element _ShortTitle { get; set; }
    /// <summary>
    /// Allows filtering of evidences that are appropriate for use versus not.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// An explanatory or alternate title for the Evidence giving additional information about its content.
    /// </summary>
    public string Subtitle { get; set; }
    /// <summary>
    /// Extension container element for Subtitle
    /// </summary>
    public Element _Subtitle { get; set; }
    /// <summary>
    /// This name does not need to be machine-processing friendly and may contain punctuation, white-space, etc.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Extension container element for Title
    /// </summary>
    public Element _Title { get; set; }
    /// <summary>
    /// Descriptive topics related to the content of the Evidence. Topics provide a high-level categorization grouping types of Evidences that can be useful for filtering and searching.
    /// </summary>
    public List<CodeableConcept> Topic { get; set; }
    /// <summary>
    /// Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.
    /// The determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). 
    /// In some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.
    /// </summary>
    public string Url { get; set; }
    /// <summary>
    /// Extension container element for Url
    /// </summary>
    public Element _Url { get; set; }
    /// <summary>
    /// When multiple useContexts are specified, there is no expectation that all or any of the contexts apply.
    /// </summary>
    public List<UsageContext> UseContext { get; set; }
    /// <summary>
    /// There may be different evidence instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the evidence with the format [url]|[version].
    /// </summary>
    public string Version { get; set; }
    /// <summary>
    /// Extension container element for Version
    /// </summary>
    public Element _Version { get; set; }
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

      writer.WriteString("approvalDate", ApprovalDate);

      if (_ApprovalDate != null)
      {
        writer.WritePropertyName("_approvalDate");
        _ApprovalDate.SerializeJson(ref writer, options);
      }

      if ((Author != null) && (Author.Count != 0))
      {
        writer.WritePropertyName("author");
        writer.WriteStartArray();

        foreach (ContactDetail valAuthor in Author)
        {
          valAuthor.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Contact != null) && (Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();

        foreach (ContactDetail valContact in Contact)
        {
          valContact.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("copyright", Copyright);

      if (_Copyright != null)
      {
        writer.WritePropertyName("_copyright");
        _Copyright.SerializeJson(ref writer, options);
      }

      writer.WriteString("date", Date);

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(ref writer, options);
      }

      writer.WriteString("description", Description);

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(ref writer, options);
      }

      if ((Editor != null) && (Editor.Count != 0))
      {
        writer.WritePropertyName("editor");
        writer.WriteStartArray();

        foreach (ContactDetail valEditor in Editor)
        {
          valEditor.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (EffectivePeriod != null)
      {
        writer.WritePropertyName("effectivePeriod");
        EffectivePeriod.SerializeJson(ref writer, options);
      }

      if ((Endorser != null) && (Endorser.Count != 0))
      {
        writer.WritePropertyName("endorser");
        writer.WriteStartArray();

        foreach (ContactDetail valEndorser in Endorser)
        {
          valEndorser.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WritePropertyName("exposureBackground");
      ExposureBackground.SerializeJson(ref writer, options);

      if ((ExposureVariant != null) && (ExposureVariant.Count != 0))
      {
        writer.WritePropertyName("exposureVariant");
        writer.WriteStartArray();

        foreach (Reference valExposureVariant in ExposureVariant)
        {
          valExposureVariant.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
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

      if ((Jurisdiction != null) && (Jurisdiction.Count != 0))
      {
        writer.WritePropertyName("jurisdiction");
        writer.WriteStartArray();

        foreach (CodeableConcept valJurisdiction in Jurisdiction)
        {
          valJurisdiction.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("lastReviewDate", LastReviewDate);

      if (_LastReviewDate != null)
      {
        writer.WritePropertyName("_lastReviewDate");
        _LastReviewDate.SerializeJson(ref writer, options);
      }

      writer.WriteString("name", Name);

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(ref writer, options);
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

      if ((Outcome != null) && (Outcome.Count != 0))
      {
        writer.WritePropertyName("outcome");
        writer.WriteStartArray();

        foreach (Reference valOutcome in Outcome)
        {
          valOutcome.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("publisher", Publisher);

      if (_Publisher != null)
      {
        writer.WritePropertyName("_publisher");
        _Publisher.SerializeJson(ref writer, options);
      }

      if ((RelatedArtifact != null) && (RelatedArtifact.Count != 0))
      {
        writer.WritePropertyName("relatedArtifact");
        writer.WriteStartArray();

        foreach (RelatedArtifact valRelatedArtifact in RelatedArtifact)
        {
          valRelatedArtifact.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Reviewer != null) && (Reviewer.Count != 0))
      {
        writer.WritePropertyName("reviewer");
        writer.WriteStartArray();

        foreach (ContactDetail valReviewer in Reviewer)
        {
          valReviewer.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("shortTitle", ShortTitle);

      if (_ShortTitle != null)
      {
        writer.WritePropertyName("_shortTitle");
        _ShortTitle.SerializeJson(ref writer, options);
      }

      writer.WriteString("status", Status);

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(ref writer, options);
      }

      writer.WriteString("subtitle", Subtitle);

      if (_Subtitle != null)
      {
        writer.WritePropertyName("_subtitle");
        _Subtitle.SerializeJson(ref writer, options);
      }

      writer.WriteString("title", Title);

      if (_Title != null)
      {
        writer.WritePropertyName("_title");
        _Title.SerializeJson(ref writer, options);
      }

      if ((Topic != null) && (Topic.Count != 0))
      {
        writer.WritePropertyName("topic");
        writer.WriteStartArray();

        foreach (CodeableConcept valTopic in Topic)
        {
          valTopic.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("url", Url);

      if (_Url != null)
      {
        writer.WritePropertyName("_url");
        _Url.SerializeJson(ref writer, options);
      }

      if ((UseContext != null) && (UseContext.Count != 0))
      {
        writer.WritePropertyName("useContext");
        writer.WriteStartArray();

        foreach (UsageContext valUseContext in UseContext)
        {
          valUseContext.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("version", Version);

      if (_Version != null)
      {
        writer.WritePropertyName("_version");
        _Version.SerializeJson(ref writer, options);
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
        case "approvalDate":
          ApprovalDate = reader.GetString();
          break;

        case "_approvalDate":
          _ApprovalDate = new Fhir.R4.Models.Element();
          _ApprovalDate.DeserializeJson(ref reader, options);
          break;

        case "author":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Author = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ContactDetail objAuthor = new Fhir.R4.Models.ContactDetail();
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

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contact = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ContactDetail objContact = new Fhir.R4.Models.ContactDetail();
            objContact.DeserializeJson(ref reader, options);
            Contact.Add(objContact);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Contact.Count == 0)
          {
            Contact = null;
          }

          break;

        case "copyright":
          Copyright = reader.GetString();
          break;

        case "_copyright":
          _Copyright = new Fhir.R4.Models.Element();
          _Copyright.DeserializeJson(ref reader, options);
          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new Fhir.R4.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new Fhir.R4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "editor":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Editor = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ContactDetail objEditor = new Fhir.R4.Models.ContactDetail();
            objEditor.DeserializeJson(ref reader, options);
            Editor.Add(objEditor);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Editor.Count == 0)
          {
            Editor = null;
          }

          break;

        case "effectivePeriod":
          EffectivePeriod = new Fhir.R4.Models.Period();
          EffectivePeriod.DeserializeJson(ref reader, options);
          break;

        case "endorser":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Endorser = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ContactDetail objEndorser = new Fhir.R4.Models.ContactDetail();
            objEndorser.DeserializeJson(ref reader, options);
            Endorser.Add(objEndorser);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Endorser.Count == 0)
          {
            Endorser = null;
          }

          break;

        case "exposureBackground":
          ExposureBackground = new Fhir.R4.Models.Reference();
          ExposureBackground.DeserializeJson(ref reader, options);
          break;

        case "exposureVariant":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ExposureVariant = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objExposureVariant = new Fhir.R4.Models.Reference();
            objExposureVariant.DeserializeJson(ref reader, options);
            ExposureVariant.Add(objExposureVariant);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ExposureVariant.Count == 0)
          {
            ExposureVariant = null;
          }

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

        case "jurisdiction":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Jurisdiction = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objJurisdiction = new Fhir.R4.Models.CodeableConcept();
            objJurisdiction.DeserializeJson(ref reader, options);
            Jurisdiction.Add(objJurisdiction);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Jurisdiction.Count == 0)
          {
            Jurisdiction = null;
          }

          break;

        case "lastReviewDate":
          LastReviewDate = reader.GetString();
          break;

        case "_lastReviewDate":
          _LastReviewDate = new Fhir.R4.Models.Element();
          _LastReviewDate.DeserializeJson(ref reader, options);
          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new Fhir.R4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
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

        case "outcome":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Outcome = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objOutcome = new Fhir.R4.Models.Reference();
            objOutcome.DeserializeJson(ref reader, options);
            Outcome.Add(objOutcome);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Outcome.Count == 0)
          {
            Outcome = null;
          }

          break;

        case "publisher":
          Publisher = reader.GetString();
          break;

        case "_publisher":
          _Publisher = new Fhir.R4.Models.Element();
          _Publisher.DeserializeJson(ref reader, options);
          break;

        case "relatedArtifact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          RelatedArtifact = new List<RelatedArtifact>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.RelatedArtifact objRelatedArtifact = new Fhir.R4.Models.RelatedArtifact();
            objRelatedArtifact.DeserializeJson(ref reader, options);
            RelatedArtifact.Add(objRelatedArtifact);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (RelatedArtifact.Count == 0)
          {
            RelatedArtifact = null;
          }

          break;

        case "reviewer":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Reviewer = new List<ContactDetail>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ContactDetail objReviewer = new Fhir.R4.Models.ContactDetail();
            objReviewer.DeserializeJson(ref reader, options);
            Reviewer.Add(objReviewer);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Reviewer.Count == 0)
          {
            Reviewer = null;
          }

          break;

        case "shortTitle":
          ShortTitle = reader.GetString();
          break;

        case "_shortTitle":
          _ShortTitle = new Fhir.R4.Models.Element();
          _ShortTitle.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subtitle":
          Subtitle = reader.GetString();
          break;

        case "_subtitle":
          _Subtitle = new Fhir.R4.Models.Element();
          _Subtitle.DeserializeJson(ref reader, options);
          break;

        case "title":
          Title = reader.GetString();
          break;

        case "_title":
          _Title = new Fhir.R4.Models.Element();
          _Title.DeserializeJson(ref reader, options);
          break;

        case "topic":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Topic = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objTopic = new Fhir.R4.Models.CodeableConcept();
            objTopic.DeserializeJson(ref reader, options);
            Topic.Add(objTopic);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Topic.Count == 0)
          {
            Topic = null;
          }

          break;

        case "url":
          Url = reader.GetString();
          break;

        case "_url":
          _Url = new Fhir.R4.Models.Element();
          _Url.DeserializeJson(ref reader, options);
          break;

        case "useContext":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          UseContext = new List<UsageContext>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.UsageContext objUseContext = new Fhir.R4.Models.UsageContext();
            objUseContext.DeserializeJson(ref reader, options);
            UseContext.Add(objUseContext);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (UseContext.Count == 0)
          {
            UseContext = null;
          }

          break;

        case "version":
          Version = reader.GetString();
          break;

        case "_version":
          _Version = new Fhir.R4.Models.Element();
          _Version.DeserializeJson(ref reader, options);
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
