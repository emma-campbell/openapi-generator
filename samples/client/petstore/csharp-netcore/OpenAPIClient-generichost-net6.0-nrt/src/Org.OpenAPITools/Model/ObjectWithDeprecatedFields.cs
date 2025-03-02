// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ObjectWithDeprecatedFields
    /// </summary>
    public partial class ObjectWithDeprecatedFields : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectWithDeprecatedFields" /> class.
        /// </summary>
        /// <param name="bars">bars</param>
        /// <param name="deprecatedRef">deprecatedRef</param>
        /// <param name="id">id</param>
        /// <param name="uuid">uuid</param>
        [JsonConstructor]
        public ObjectWithDeprecatedFields(List<string> bars, DeprecatedObject deprecatedRef, decimal id, string uuid)
        {
#pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (uuid == null)
                throw new ArgumentNullException("uuid is a required property for ObjectWithDeprecatedFields and cannot be null.");

            if (id == null)
                throw new ArgumentNullException("id is a required property for ObjectWithDeprecatedFields and cannot be null.");

            if (deprecatedRef == null)
                throw new ArgumentNullException("deprecatedRef is a required property for ObjectWithDeprecatedFields and cannot be null.");

            if (bars == null)
                throw new ArgumentNullException("bars is a required property for ObjectWithDeprecatedFields and cannot be null.");

#pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
#pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            Bars = bars;
            DeprecatedRef = deprecatedRef;
            Id = id;
            Uuid = uuid;
        }

        /// <summary>
        /// Gets or Sets Bars
        /// </summary>
        [JsonPropertyName("bars")]
        [Obsolete]
        public List<string> Bars { get; set; }

        /// <summary>
        /// Gets or Sets DeprecatedRef
        /// </summary>
        [JsonPropertyName("deprecatedRef")]
        [Obsolete]
        public DeprecatedObject DeprecatedRef { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [JsonPropertyName("id")]
        [Obsolete]
        public decimal Id { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ObjectWithDeprecatedFields {\n");
            sb.Append("  Bars: ").Append(Bars).Append("\n");
            sb.Append("  DeprecatedRef: ").Append(DeprecatedRef).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type ObjectWithDeprecatedFields
    /// </summary>
    public class ObjectWithDeprecatedFieldsJsonConverter : JsonConverter<ObjectWithDeprecatedFields>
    {
        /// <summary>
        /// A Json reader.
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ObjectWithDeprecatedFields Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            List<string> bars = default;
            DeprecatedObject deprecatedRef = default;
            decimal id = default;
            string uuid = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? propertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (propertyName)
                    {
                        case "bars":
                            bars = JsonSerializer.Deserialize<List<string>>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "deprecatedRef":
                            deprecatedRef = JsonSerializer.Deserialize<DeprecatedObject>(ref utf8JsonReader, jsonSerializerOptions);
                            break;
                        case "id":
                            id = utf8JsonReader.GetInt32();
                            break;
                        case "uuid":
                            uuid = utf8JsonReader.GetString();
                            break;
                        default:
                            break;
                    }
                }
            }

            return new ObjectWithDeprecatedFields(bars, deprecatedRef, id, uuid);
        }

        /// <summary>
        /// A Json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="objectWithDeprecatedFields"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ObjectWithDeprecatedFields objectWithDeprecatedFields, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("bars");
            JsonSerializer.Serialize(writer, objectWithDeprecatedFields.Bars, jsonSerializerOptions);
            writer.WritePropertyName("deprecatedRef");
            JsonSerializer.Serialize(writer, objectWithDeprecatedFields.DeprecatedRef, jsonSerializerOptions);
            writer.WriteNumber("id", objectWithDeprecatedFields.Id);
            writer.WriteString("uuid", objectWithDeprecatedFields.Uuid);

            writer.WriteEndObject();
        }
    }
}
