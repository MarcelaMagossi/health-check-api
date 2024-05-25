﻿using System.Net;

namespace HealthCheck.Domain.HealthCheck;

public class MonitoredApi
{
    public string? Hash { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Url { get; set; }
    public HttpMethod? HttpMethod { get; set; }
    public HttpStatusCode ExpectedCode { get; set; }
    public string? ExpectedMessage { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}