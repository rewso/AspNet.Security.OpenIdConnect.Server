/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OpenIdConnect.Server
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNet.Http;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace AspNet.Security.OpenIdConnect.Server {
    /// <summary>
    /// Provides context information used in validating an OpenIdConnect authorization request.
    /// </summary>
    public sealed class ValidateAuthorizationRequestContext : BaseValidatingContext<OpenIdConnectServerOptions> {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateAuthorizationRequestContext"/> class
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="options"></param>
        /// <param name="request"></param>
        /// <param name="clientContext"></param>
        internal ValidateAuthorizationRequestContext(
            HttpContext httpContext,
            OpenIdConnectServerOptions options,
            OpenIdConnectMessage request,
            ValidateClientRedirectUriContext clientContext)
            : base(httpContext, options) {
            Request = request;
            ClientContext = clientContext;
            Validated();
        }

        /// <summary>
        /// Gets the authorization request.
        /// </summary>
        public new OpenIdConnectMessage Request { get; }

        /// <summary>
        /// Gets the client context. 
        /// </summary>
        public ValidateClientRedirectUriContext ClientContext { get; }
    }
}
