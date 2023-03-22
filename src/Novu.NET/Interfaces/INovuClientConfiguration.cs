﻿namespace Novu.NET.Interfaces;

public interface INovuClientConfiguration
{
    /// <summary>
    /// Full URL to where the Novu API is housed. Defaults to
    /// https://api.novu.co/v1
    /// </summary>
    public string Url { get; set; }
    
    /// <summary>
    /// Api Key used for authentication. Found on the Settings
    /// page > API Keys > API Key.
    /// </summary>
    public string ApiKey { get; set; }
    
    /// <summary>
    /// Application Identifier. Found on the Settings page >
    /// API Keys > Application Identifier
    /// </summary>
    public string ApplicationId { get; set; }
}