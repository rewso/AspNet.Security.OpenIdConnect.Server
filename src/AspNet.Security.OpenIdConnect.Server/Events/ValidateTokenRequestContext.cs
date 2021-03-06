/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OpenIdConnect.Server
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNet.Http;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace AspNet.Security.OpenIdConnect.Server {
    /// <summary>
    /// Provides context information used in validating an OpenIdConnect token request.
    /// </summary>
    public sealed class ValidateTokenRequestContext : BaseValidatingContext<OpenIdConnectServerOptions> {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateTokenRequestContext"/> class
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="options"></param>
        /// <param name="request"></param>
        /// <param name="context"></param>
        internal ValidateTokenRequestContext(
            HttpContext httpContext,
            OpenIdConnectServerOptions options,
            OpenIdConnectMessage request,
            BaseValidatingClientContext context)
            : base(httpContext, options) {
            Request = request;
            ClientContext = context;
            Validated();
        }

        /// <summary>
        /// Gets the token request data.
        /// </summary>
        public new OpenIdConnectMessage Request { get; }

        /// <summary>
        /// Gets information about the client.
        /// </summary>
        public BaseValidatingClientContext ClientContext { get; }
    }
}
