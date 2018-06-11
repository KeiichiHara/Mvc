// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Core.Infrastructure;

namespace Microsoft.AspNetCore.Mvc
{
    /// <summary>
    /// A <see cref="StatusCodeResult"/> that when executed will produce a 204 No Content response.
    /// </summary>
    [StatusCode(StatusCodes.Status400BadRequest)]
    public class NoContentResult : StatusCodeResult
    {
        /// <summary>
        /// Initializes a new <see cref="NoContentResult"/> instance.
        /// </summary>
        public NoContentResult()
            : base(StatusCodes.Status204NoContent)
        {
        }
    }
}
