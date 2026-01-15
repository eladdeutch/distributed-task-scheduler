namespace DistributedTaskScheduler.Core.Entities;

/// <summary>
/// Represents the result of a task execution attempt.
/// </summary>
public record TaskExecutionResult(
    bool Success,
    string? ErrorMessage,
    string? WorkerId,
    DateTime StartedAt,
    DateTime? CompletedAt,
    int AttemptNumber
);
