/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// NullableEnumModel
    /// </summary>
    [DataContract]
        public partial class NullableEnumModel :  IEquatable<NullableEnumModel>
    {
        /// <summary>
        /// Defines EnumProp
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum EnumPropEnum
        {
            /// <summary>
            /// Enum A for value: a
            /// </summary>
            [EnumMember(Value = "a")]
            A = 1,
            /// <summary>
            /// Enum B for value: b
            /// </summary>
            [EnumMember(Value = "b")]
            B = 2,
            /// <summary>
            /// Enum Null for value: null
            /// </summary>
            [EnumMember(Value = null)]
            Null = 3        }
        /// <summary>
        /// Gets or Sets EnumProp
        /// </summary>
        [DataMember(Name="enumProp", EmitDefaultValue=false)]
        public EnumPropEnum? EnumProp { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NullableEnumModel" /> class.
        /// </summary>
        /// <param name="enumProp">enumProp.</param>
        public NullableEnumModel(EnumPropEnum? enumProp = default(EnumPropEnum?))
        {
            this.EnumProp = enumProp;
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NullableEnumModel {\n");
            sb.Append("  EnumProp: ").Append(EnumProp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NullableEnumModel);
        }

        /// <summary>
        /// Returns true if NullableEnumModel instances are equal
        /// </summary>
        /// <param name="input">Instance of NullableEnumModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NullableEnumModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnumProp == input.EnumProp ||
                    (this.EnumProp != null &&
                    this.EnumProp.Equals(input.EnumProp))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EnumProp != null)
                    hashCode = hashCode * 59 + this.EnumProp.GetHashCode();
                return hashCode;
            }
        }
    }
}