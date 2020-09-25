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
  /// A expression that is evaluated in a specified context and returns a value. The context of use of the expression must specify the context in which the expression is evaluated, and how the result of the expression is used.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonComponentConverter<Expression>))]
  public class Expression : Element,  IFhirJsonSerializable {
    /// <summary>
    /// A brief, natural language description of the condition that effectively communicates the intended semantics.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// An expression in the specified language that returns a value.
    /// </summary>
    public string ExpressionField { get; set; }
    /// <summary>
    /// Extension container element for Expression
    /// </summary>
    public Element _ExpressionField { get; set; }
    /// <summary>
    /// The media type of the language for the expression.
    /// </summary>
    public string Language { get; set; }
    /// <summary>
    /// Extension container element for Language
    /// </summary>
    public Element _Language { get; set; }
    /// <summary>
    /// A short name assigned to the expression to allow for multiple reuse of the expression in the context where it is defined.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Extension container element for Name
    /// </summary>
    public Element _Name { get; set; }
    /// <summary>
    /// If both a reference and an expression is found, the reference SHALL point to the same expression.
    /// </summary>
    public string Reference { get; set; }
    /// <summary>
    /// Extension container element for Reference
    /// </summary>
    public Element _Reference { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(ref Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.Element)this).SerializeJson(ref writer, options, false);

      writer.WriteString("description", Description);

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(ref writer, options);
      }

      writer.WriteString("expression", ExpressionField);

      if (_ExpressionField != null)
      {
        writer.WritePropertyName("_expression");
        _ExpressionField.SerializeJson(ref writer, options);
      }

      writer.WriteString("language", Language);

      if (_Language != null)
      {
        writer.WritePropertyName("_language");
        _Language.SerializeJson(ref writer, options);
      }

      writer.WriteString("name", Name);

      if (_Name != null)
      {
        writer.WritePropertyName("_name");
        _Name.SerializeJson(ref writer, options);
      }

      writer.WriteString("reference", Reference);

      if (_Reference != null)
      {
        writer.WritePropertyName("_reference");
        _Reference.SerializeJson(ref writer, options);
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
        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new Fhir.R4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "expression":
          ExpressionField = reader.GetString();
          break;

        case "_expression":
          _ExpressionField = new Fhir.R4.Models.Element();
          _ExpressionField.DeserializeJson(ref reader, options);
          break;

        case "language":
          Language = reader.GetString();
          break;

        case "_language":
          _Language = new Fhir.R4.Models.Element();
          _Language.DeserializeJson(ref reader, options);
          break;

        case "name":
          Name = reader.GetString();
          break;

        case "_name":
          _Name = new Fhir.R4.Models.Element();
          _Name.DeserializeJson(ref reader, options);
          break;

        case "reference":
          Reference = reader.GetString();
          break;

        case "_reference":
          _Reference = new Fhir.R4.Models.Element();
          _Reference.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
