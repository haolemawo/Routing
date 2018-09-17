﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Routing;
using RoutingSample.Web.AuthorizationMiddleware;

namespace Microsoft.AspNetCore.Builder
{
    public static class ApplyEndpointExtensions
    {
        public static IApplyEndpointBuilder RequireAuthorization(this IApplyEndpointBuilder builder, params string[] roles)
        {
            builder.Apply(endpointBuilder => endpointBuilder.Metadata.Add(new AuthorizationMetadata(roles)));
            return builder;
        }
    }
}
