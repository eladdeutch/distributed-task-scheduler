using DistributedTaskScheduler.Core.Enums;
using DistributedTaskScheduler.Core.ValueObjects;

namespace DistributedTaskScheduler.Core.Entities;

/// <summary>
/// Represents a scheduled task in the system.
/// </summary>
public class ScheduledTask
{
    /// <summary>
    /// Unique identifier for the task.
    /// </summary>
    public string Id { get; set; } = null!;

    /// <summary>
    /// Human-readable name for the task.
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Type of task (HttpCallback, MessagePublish, Custom).
    /// </summary>
    public TaskTypeEnum Type { get; set; }

    /// <summary>
    /// Current status of the task.
    /// </summary>
    public TaskStatusEnum Status { get; set; } = TaskStatusEnum.Pending;

    /// <summary>
    /// When the task should be executed.
    /// </summary>
    public DateTime ScheduledTime { get; set; }

    /// <summary>
    /// Optional cron expression for recurring tasks.
    /// </summary>
    public string? CronExpression { get; set; }

    /// <summary>
    /// Next scheduled run time (for recurring tasks).
    /// </summary>
    public DateTime? NextRunTime { get; set; }

    /// <summary>
    /// Priority level (0-10, higher = more urgent).
    /// </summary>
    public int Priority { get; set; } = 5;

    /// <summary>
    /// JSON payload containing task-specific data.
    /// </summary>
    public string? PayloadJson { get; set; }

    /// <summary>
    /// Retry policy for failed executions.
    /// </summary>
    public RetryPolicy RetryPolicy { get; set; } = new();

    /// <summary>
    /// Current retry attempt count.
    /// </summary>
    public int RetryCount { get; set; }

    /// <summary>
    /// When the task was created.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// When the task was last updated.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }

    /// <summary>
    /// When execution started.
    /// </summary>
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// When execution completed.
    /// </summary>
    public DateTime? CompletedAt { get; set; }

    /// <summary>
    /// Last error message (if failed).
    /// </summary>
    public string? ErrorMessage { get; set; }

    /// <summary>
    /// ID of the worker processing this task.
    /// </summary>
    public string? WorkerId { get; set; }
}
