namespace DistributedTaskScheduler.Core.Enums;

/// <summary>
/// Types of tasks that can be scheduled.
/// </summary>
public enum TaskTypeEnum
{
    /// <summary>
    /// Task that makes an HTTP callback to a specified URL.
    /// </summary>
    HttpCallback,

    /// <summary>
    /// Task that publishes a message to a queue/topic.
    /// </summary>
    MessagePublish,

    /// <summary>
    /// Custom task type with user-defined handling.
    /// </summary>
    Custom
}
