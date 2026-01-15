namespace DistributedTaskScheduler.Core.Configuration;

/// <summary>
/// Worker service configuration settings.
/// </summary>
public class WorkerSettings
{
    public const string SectionName = "Worker";

    /// <summary>
    /// Interval between polling for due tasks (milliseconds).
    /// </summary>
    public int PollingIntervalMs { get; set; } = 1000;

    /// <summary>
    /// Maximum number of tasks to fetch per poll.
    /// </summary>
    public int BatchSize { get; set; } = 100;

    /// <summary>
    /// Default timeout for task execution (seconds).
    /// </summary>
    public int DefaultTimeoutSeconds { get; set; } = 30;

    /// <summary>
    /// Timeout for graceful shutdown (seconds).
    /// </summary>
    public int ShutdownTimeoutSeconds { get; set; } = 30;
}
