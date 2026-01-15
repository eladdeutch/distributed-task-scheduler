namespace DistributedTaskScheduler.Core.DTOs;

/// <summary>
/// Response DTO for paginated task list.
/// </summary>
public class TaskListResponse
{
    /// <summary>
    /// List of tasks.
    /// </summary>
    public List<TaskResponse> Items { get; set; } = new();

    /// <summary>
    /// Total number of tasks matching the filter.
    /// </summary>
    public int TotalCount { get; set; }

    /// <summary>
    /// Current page number.
    /// </summary>
    public int Page { get; set; }

    /// <summary>
    /// Number of items per page.
    /// </summary>
    public int PageSize { get; set; }

    /// <summary>
    /// Total number of pages.
    /// </summary>
    public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
}
