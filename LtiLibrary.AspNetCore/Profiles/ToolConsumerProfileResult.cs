﻿using LtiLibrary.NetCore.Common;
using Microsoft.AspNetCore.Mvc;

namespace LtiLibrary.AspNetCore.Profiles
{
    /// <summary>
    /// Ensure the JsonResult has the right Content-Type.
    /// </summary>
    public class ToolConsumerProfileResult : JsonResult
    {
        public ToolConsumerProfileResult(object value) : base(value)
        {
            ContentType = LtiConstants.ToolConsumerProfileMediaType;
        }
    }
}