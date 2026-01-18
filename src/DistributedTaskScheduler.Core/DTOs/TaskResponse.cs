using DistributedTaskScheduler.Core.Enums;
using DistributedTaskScheduler.Core.ValueObjects;

namespace DistributedTaskScheduler.Core.DTOs;

/// <summary>
/// Response DTO for task details.
/// </summary>
public class TaskResponse
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public TaskTypeEnum Type { get; set; }
    public TaskStatusEnum Status { get; set; }
    public DateTime ScheduledTime { get; set; }
    public string? CronExpression { get; set; }
    public DateTime? NextRunTime { get; set; }
    public int Priority { get; set; }
    public object? Payload { get; set; }
    public RetryPolicy RetryPolicy { get; set; } = null!;
    public int RetryCount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public DateTime? StartedAt { get; set; }
    public DateTime? CompletedAt { get; set; }
    public string? ErrorMessage { get; set; }
    public string? WorkerId { get; set; }
}
