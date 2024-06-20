namespace IceBrown.Core.Models.Response;

public class BaseResponse
{
    public string Code { get; set; } = null!;
    public string? Message { get; set; }
    public string TraceId { get; set; } = null!;

    public BaseResponse()
    {
        //TODO: Initial value
    }

    public BaseResponse(string code, string message, string traceId)
    {
        Code = code;
        Message = message;
        TraceId = traceId;
    }
}