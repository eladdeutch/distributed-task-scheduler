using DistributedTaskScheduler.Core.Enums;
using DistributedTaskScheduler.Core.ValueObjects;

namespace DistributedTaskScheduler.Core.DTOs;

/// <summary>
/// Request DTO for creating a new scheduled task.
/// </summary>
public class CreateTaskRequest
{
    /// <summary>
    /// Human-readable name for the task.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Type of task to create.
    /// </summary>
    public TaskTypeEnum Type { get; set; }

    /// <summary>
    /// When the task should be executed.
    /// </summary>
    public DateTime ScheduledTime { get; set; }

    /// <summary>
    /// Optional cron expression for recurring tasks.
    /// </summary>
    public string? CronExpression { get; set; }

    /// <summary>
    /// Priority level (0-10, higher = more urgent).
    /// </summary>
    public int Priority { get; set; } = 5;

    /// <summary>
    /// JSON payload containing task-specific data.
    /// </summary>
    public object? Payload { get; set; }

    /// <summary>
    /// Optional retry policy override.
    /// </summary>
    public RetryPolicy? RetryPolicy { get; set; }
}
