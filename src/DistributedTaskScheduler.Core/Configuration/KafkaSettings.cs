namespace DistributedTaskScheduler.Core.Configuration;

/// <summary>
/// Kafka configuration settings.
/// </summary>
public class KafkaSettings
{
    public const string SectionName = "Kafka";

    /// <summary>
    /// Kafka bootstrap servers (comma-separated).
    /// </summary>
    public string BootstrapServers { get; set; } = "localhost:9092";

    /// <summary>
    /// Consumer group ID.
    /// </summary>
    public string GroupId { get; set; } = "task-scheduler-workers";

    /// <summary>
    /// Topic for scheduled tasks.
    /// </summary>
    public string TasksTopic { get; set; } = "scheduled-tasks";

    /// <summary>
    /// Topic for task execution results.
    /// </summary>
    public string ResultsTopic { get; set; } = "task-results";

    /// <summary>
    /// Topic for dead letter queue.
    /// </summary>
    public string DeadLetterTopic { get; set; } = "task-dead-letter";

    /// <summary>
    /// Auto offset reset behavior (Earliest, Latest).
    /// </summary>
    public string AutoOffsetReset { get; set; } = "Earliest";

    /// <summary>
    /// Whether to enable auto-commit of offsets.
    /// </summary>
    public bool EnableAutoCommit { get; set; } = false;
}
