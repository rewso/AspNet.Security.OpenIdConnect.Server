﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/aspnet-contrib/AspNet.Security.OpenIdConnect.Server
 * for more information concerning the license and the contributors participating to this project.
 */

using Microsoft.AspNet.Authentication;
using Microsoft.AspNet.Http;
using Newtonsoft.Json.Linq;

namespace AspNet.Security.OpenIdConnect.Server {
    /// <summary>
    /// Provides context information used at the end of a token-endpoint-request.
    /// </summary>
    public sealed class TokenEndpointResponseContext : BaseControlContext<OpenIdConnectServerOptions> {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenEndpointResponseContext"/> class
        /// </summary>
        /// <param name="httpContext"></param>
        /// <param name="options"></param>
        /// <param name="payload"></param>
        internal TokenEndpointResponseContext(
            HttpContext httpContext,
            OpenIdConnectServerOptions options,
            JObject payload)
            : base(httpContext, options) {
            Payload = payload;
        }

        /// <summary>
        /// Gets the JSON payload returned to the client application.
        /// </summary>
        public JObject Payload { get; }
    }
}
