// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Devices.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Devices;
    using Microsoft.Azure.Management.Devices.Fluent;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Use to provide parameters when requesting an import of all devices in
    /// the hub.
    /// </summary>
    public partial class ImportDevicesRequestInner
    {
        /// <summary>
        /// Initializes a new instance of the ImportDevicesRequestInner class.
        /// </summary>
        public ImportDevicesRequestInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportDevicesRequestInner class.
        /// </summary>
        /// <param name="inputBlobContainerUri">The input blob container
        /// URI.</param>
        /// <param name="outputBlobContainerUri">The output blob container
        /// URI.</param>
        public ImportDevicesRequestInner(string inputBlobContainerUri, string outputBlobContainerUri)
        {
            InputBlobContainerUri = inputBlobContainerUri;
            OutputBlobContainerUri = outputBlobContainerUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the input blob container URI.
        /// </summary>
        [JsonProperty(PropertyName = "InputBlobContainerUri")]
        public string InputBlobContainerUri { get; set; }

        /// <summary>
        /// Gets or sets the output blob container URI.
        /// </summary>
        [JsonProperty(PropertyName = "OutputBlobContainerUri")]
        public string OutputBlobContainerUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (InputBlobContainerUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "InputBlobContainerUri");
            }
            if (OutputBlobContainerUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OutputBlobContainerUri");
            }
        }
    }
}