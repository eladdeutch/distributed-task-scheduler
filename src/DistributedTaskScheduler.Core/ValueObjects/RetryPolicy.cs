namespace DistributedTaskScheduler.Core.ValueObjects;

/// <summary>
/// Defines the retry behavior for failed task executions.
/// </summary>
public class RetryPolicy
{
    /// <summary>
    /// Maximum number of retry attempts.
    /// </summary>
    public int MaxRetries { get; set; } = 3;

    /// <summary>
    /// Delay between retry attempts in seconds.
    /// </summary>
    public int RetryDelaySeconds { get; set; } = 60;
}
