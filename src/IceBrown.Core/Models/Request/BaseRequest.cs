namespace IceBrown.Core.Models.Request;

public class BaseRequest(string traceId)
{
    public string TraceId { get; set; } = traceId;
}