namespace DistributedTaskScheduler.Core.Configuration;

/// <summary>
/// General task scheduler configuration settings.
/// </summary>
public class TaskSchedulerSettings
{
    public const string SectionName = "TaskScheduler";

    /// <summary>
    /// Default timeout for task execution (seconds).
    /// </summary>
    public int DefaultTimeoutSeconds { get; set; } = 30;

    /// <summary>
    /// Maximum allowed payload size in bytes (default: 64KB).
    /// </summary>
    public int MaxPayloadSizeBytes { get; set; } = 65536;

    /// <summary>
    /// Default retry policy for failed tasks.
    /// </summary>
    public RetryPolicySettings DefaultRetryPolicy { get; set; } = new();
}

/// <summary>
/// Retry policy configuration.
/// </summary>
public class RetryPolicySettings
{
    /// <summary>
    /// Maximum number of retry attempts.
    /// </summary>
    public int MaxRetries { get; set; } = 3;

    /// <summary>
    /// Delay between retry attempts (seconds).
    /// </summary>
    public int RetryDelaySeconds { get; set; } = 60;
}
