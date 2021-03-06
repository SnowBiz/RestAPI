﻿//-----------------------------------------------------------------------
// <copyright file="WebApiConfig.cs">
//  Copyright (c) 2017 All Rights Reserved
// <author>Alan Snow</author>
// </copyright>
//-----------------------------------------------------------------------

namespace RestAPI
{
    using System.Web.Http;

    /// <summary>
    /// Web API Configuration
    /// </summary>
    public static class WebApiConfig
    {
        /// <summary>
        /// Registers the specified configuration.
        /// </summary>
        /// <param name="config">The configuration.</param>
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
