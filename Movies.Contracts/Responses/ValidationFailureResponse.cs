namespace Movies.Contracts.Responses;

public class ValidationFailureResponse
{
    public required IEnumerable<ValidationResponse> Errors { get; init; }
    
}

public class ValidationResponse
{
    public string PropertyName { get; init; }
    public string Message { get; init; }
}