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
  /// Details where to send notifications when resources are received that meet the criteria.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<SubscriptionChannel>))]
  public class SubscriptionChannel : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// For rest-hook, and websocket, the end-point must be an http: or https: URL; for email, a mailto: url, for sms, a tel: url, and for message the endpoint can be in any form of url the server understands (usually, http: or mllp:). The URI is allowed to be relative; in which case, it is relative to the server end-point (since there may be more than one, clients should avoid using relative URIs).
    /// </summary>
    public string Endpoint { get; set; }
    /// <summary>
    /// Extension container element for Endpoint
    /// </summary>
    public Element _Endpoint { get; set; }
    /// <summary>
    /// Exactly what these mean depend on the channel type. They can convey additional information to the recipient and/or meet security requirements; for example, support of multiple headers in the outgoing notifications for rest-hook type subscriptions.
    /// </summary>
    public List<string> Header { get; set; }
    /// <summary>
    /// Extension container element for Header
    /// </summary>
    public List<Element> _Header { get; set; }
    /// <summary>
    /// Sending the payload has obvious security implications. The server is responsible for ensuring that the content is appropriately secured.
    /// </summary>
    public string Payload { get; set; }
    /// <summary>
    /// Extension container element for Payload
    /// </summary>
    public Element _Payload { get; set; }
    /// <summary>
    /// The type of channel to send notifications on.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
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

      writer.WriteString("endpoint", Endpoint);

      if (_Endpoint != null)
      {
        writer.WritePropertyName("_endpoint");
        _Endpoint.SerializeJson(ref writer, options);
      }

      if ((Header != null) && (Header.Count != 0))
      {
        writer.WritePropertyName("header");
        writer.WriteStartArray();

        foreach (string valHeader in Header)
        {
          writer.WriteStringValue(valHeader);
        }

        writer.WriteEndArray();
      }

      if ((_Header != null) && (_Header.Count != 0))
      {
        writer.WritePropertyName("_header");
        writer.WriteStartArray();

        foreach (Element val_Header in _Header)
        {
          val_Header.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("payload", Payload);

      if (_Payload != null)
      {
        writer.WritePropertyName("_payload");
        _Payload.SerializeJson(ref writer, options);
      }

      writer.WriteString("type", Type);

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(ref writer, options);
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
        case "endpoint":
          Endpoint = reader.GetString();
          break;

        case "_endpoint":
          _Endpoint = new Fhir.R4.Models.Element();
          _Endpoint.DeserializeJson(ref reader, options);
          break;

        case "header":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Header = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Header.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Header.Count == 0)
          {
            Header = null;
          }

          break;

        case "_header":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Header = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Element obj_Header = new Fhir.R4.Models.Element();
            obj_Header.DeserializeJson(ref reader, options);
            _Header.Add(obj_Header);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Header.Count == 0)
          {
            _Header = null;
          }

          break;

        case "payload":
          Payload = reader.GetString();
          break;

        case "_payload":
          _Payload = new Fhir.R4.Models.Element();
          _Payload.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new Fhir.R4.Models.Element();
          _Type.DeserializeJson(ref reader, options);
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
  /// The subscription resource is used to define a push-based subscription from a server to another system. Once a subscription is registered with the server, the server checks every resource that is created or updated, and if the resource matches the given criteria, it sends a message on the defined "channel" so that another system can take an appropriate action.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonResourceConverter))]
  public class Subscription : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "Subscription";
    /// <summary>
    /// Details where to send notifications when resources are received that meet the criteria.
    /// </summary>
    public SubscriptionChannel Channel { get; set; }
    /// <summary>
    /// Contact details for a human to contact about the subscription. The primary use of this for system administrator troubleshooting.
    /// </summary>
    public List<ContactPoint> Contact { get; set; }
    /// <summary>
    /// The rules are search criteria (without the [base] part). Like Bundle.entry.request.url, it has no leading "/".
    /// </summary>
    public string Criteria { get; set; }
    /// <summary>
    /// Extension container element for Criteria
    /// </summary>
    public Element _Criteria { get; set; }
    /// <summary>
    /// The server is permitted to deviate from this time but should observe it.
    /// </summary>
    public string End { get; set; }
    /// <summary>
    /// Extension container element for End
    /// </summary>
    public Element _End { get; set; }
    /// <summary>
    /// A record of the last error that occurred when the server processed a notification.
    /// </summary>
    public string Error { get; set; }
    /// <summary>
    /// Extension container element for Error
    /// </summary>
    public Element _Error { get; set; }
    /// <summary>
    /// A description of why this subscription is defined.
    /// </summary>
    public string Reason { get; set; }
    /// <summary>
    /// Extension container element for Reason
    /// </summary>
    public Element _Reason { get; set; }
    /// <summary>
    /// A client can only submit subscription resources in the requested or off state. Only the server can  move a subscription from requested to active, and then to error. Either the server or the client can turn a subscription off.
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

      writer.WritePropertyName("channel");
      Channel.SerializeJson(ref writer, options);

      if ((Contact != null) && (Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();

        foreach (ContactPoint valContact in Contact)
        {
          valContact.SerializeJson(ref writer, options, true);
        }

        writer.WriteEndArray();
      }

      writer.WriteString("criteria", Criteria);

      if (_Criteria != null)
      {
        writer.WritePropertyName("_criteria");
        _Criteria.SerializeJson(ref writer, options);
      }

      writer.WriteString("end", End);

      if (_End != null)
      {
        writer.WritePropertyName("_end");
        _End.SerializeJson(ref writer, options);
      }

      writer.WriteString("error", Error);

      if (_Error != null)
      {
        writer.WritePropertyName("_error");
        _Error.SerializeJson(ref writer, options);
      }

      writer.WriteString("reason", Reason);

      if (_Reason != null)
      {
        writer.WritePropertyName("_reason");
        _Reason.SerializeJson(ref writer, options);
      }

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
        case "channel":
          Channel = new Fhir.R4.Models.SubscriptionChannel();
          Channel.DeserializeJson(ref reader, options);
          break;

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contact = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.ContactPoint objContact = new Fhir.R4.Models.ContactPoint();
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

        case "criteria":
          Criteria = reader.GetString();
          break;

        case "_criteria":
          _Criteria = new Fhir.R4.Models.Element();
          _Criteria.DeserializeJson(ref reader, options);
          break;

        case "end":
          End = reader.GetString();
          break;

        case "_end":
          _End = new Fhir.R4.Models.Element();
          _End.DeserializeJson(ref reader, options);
          break;

        case "error":
          Error = reader.GetString();
          break;

        case "_error":
          _Error = new Fhir.R4.Models.Element();
          _Error.DeserializeJson(ref reader, options);
          break;

        case "reason":
          Reason = reader.GetString();
          break;

        case "_reason":
          _Reason = new Fhir.R4.Models.Element();
          _Reason.DeserializeJson(ref reader, options);
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
