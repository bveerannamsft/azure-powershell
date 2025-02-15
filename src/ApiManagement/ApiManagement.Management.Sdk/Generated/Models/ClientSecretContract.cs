// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using System.Linq;

    /// <summary>
    /// Client or app secret used in IdentityProviders, Aad, OpenID or OAuth.
    /// </summary>
    public partial class ClientSecretContract
    {
        /// <summary>
        /// Initializes a new instance of the ClientSecretContract class.
        /// </summary>
        public ClientSecretContract()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClientSecretContract class.
        /// </summary>

        /// <param name="clientSecret">Client or app secret used in IdentityProviders, Aad, OpenID or OAuth.
        /// </param>
        public ClientSecretContract(string clientSecret = default(string))

        {
            this.ClientSecret = clientSecret;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets client or app secret used in IdentityProviders, Aad, OpenID or
        /// OAuth.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret {get; set; }
    }
}