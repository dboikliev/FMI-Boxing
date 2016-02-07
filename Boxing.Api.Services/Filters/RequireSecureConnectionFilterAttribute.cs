﻿using System;
using System.Net;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace Boxing.Api.Services.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class RequireSecureConnectionFilterAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.RequestUri.Scheme != Uri.UriSchemeHttps)
            {
                HandleNonHttpsRequest(actionContext);
            }
            else
            {
                base.OnAuthorization(actionContext);
            }
        }

        public virtual void HandleNonHttpsRequest(HttpActionContext actionContext)
        {
            actionContext.Response = new HttpResponseMessage(HttpStatusCode.Forbidden)
            {
                ReasonPhrase = "HTTPS required."
            };
        }
    }
}