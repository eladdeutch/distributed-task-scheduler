using DistributedTaskScheduler.Core.ValueObjects;

namespace DistributedTaskScheduler.Core.DTOs;

/// <summary>
/// Request DTO for updating an existing task.
/// </summary>
public class UpdateTaskRequest
{
    /// <summary>
    /// New scheduled time for the task.
    /// </summary>
    public DateTime? ScheduledTime { get; set; }

    /// <summary>
    /// New priority level.
    /// </summary>
    public int? Priority { get; set; }

    /// <summary>
    /// Updated payload.
    /// </summary>
    public object? Payload { get; set; }

    /// <summary>
    /// Updated retry policy.
    /// </summary>
    public RetryPolicy? RetryPolicy { get; set; }
}
