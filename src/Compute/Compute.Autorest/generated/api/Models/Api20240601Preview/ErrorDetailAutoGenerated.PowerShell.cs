// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.PowerShell;

    /// <summary>Error Detail message.</summary>
    [System.ComponentModel.TypeConverter(typeof(ErrorDetailAutoGeneratedTypeConverter))]
    public partial class ErrorDetailAutoGenerated
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.ErrorDetailAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGenerated DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new ErrorDetailAutoGenerated(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.ErrorDetailAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGenerated"
        /// />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGenerated DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new ErrorDetailAutoGenerated(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.ErrorDetailAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal ErrorDetailAutoGenerated(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerError = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IInnerError) content.GetValueForProperty("InnerError",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerError, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api50.IErrorDetail[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api50.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api50.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("InnerErrorExceptiontype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerErrorExceptiontype = (string) content.GetValueForProperty("InnerErrorExceptiontype",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerErrorExceptiontype, global::System.Convert.ToString);
            }
            if (content.Contains("InnerErrorErrordetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerErrorErrordetail = (string) content.GetValueForProperty("InnerErrorErrordetail",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerErrorErrordetail, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.ErrorDetailAutoGenerated"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal ErrorDetailAutoGenerated(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("InnerError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerError = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.IInnerError) content.GetValueForProperty("InnerError",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerError, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api10.InnerErrorTypeConverter.ConvertFrom);
            }
            if (content.Contains("Code"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Code = (string) content.GetValueForProperty("Code",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Code, global::System.Convert.ToString);
            }
            if (content.Contains("Target"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Target = (string) content.GetValueForProperty("Target",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Target, global::System.Convert.ToString);
            }
            if (content.Contains("Message"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Message = (string) content.GetValueForProperty("Message",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Message, global::System.Convert.ToString);
            }
            if (content.Contains("Detail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Detail = (Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api50.IErrorDetail[]) content.GetValueForProperty("Detail",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).Detail, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api50.IErrorDetail>(__y, Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api50.ErrorDetailTypeConverter.ConvertFrom));
            }
            if (content.Contains("InnerErrorExceptiontype"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerErrorExceptiontype = (string) content.GetValueForProperty("InnerErrorExceptiontype",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerErrorExceptiontype, global::System.Convert.ToString);
            }
            if (content.Contains("InnerErrorErrordetail"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerErrorErrordetail = (string) content.GetValueForProperty("InnerErrorErrordetail",((Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGeneratedInternal)this).InnerErrorErrordetail, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="ErrorDetailAutoGenerated" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="ErrorDetailAutoGenerated" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Compute.Models.Api20240601Preview.IErrorDetailAutoGenerated FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Compute.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Error Detail message.
    [System.ComponentModel.TypeConverter(typeof(ErrorDetailAutoGeneratedTypeConverter))]
    public partial interface IErrorDetailAutoGenerated

    {

    }
}