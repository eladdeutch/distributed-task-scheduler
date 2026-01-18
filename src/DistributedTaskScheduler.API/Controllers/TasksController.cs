using DistributedTaskScheduler.Core.DTOs;
using DistributedTaskScheduler.Core.Enums;
using Microsoft.AspNetCore.Mvc;

namespace DistributedTaskScheduler.API.Controllers;

/// <summary>
/// API endpoints for managing scheduled tasks.
/// </summary>
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class TasksController : ControllerBase
{
    private readonly ILogger<TasksController> _logger;

    public TasksController(ILogger<TasksController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Creates a new scheduled task.
    /// </summary>
    /// <param name="request">The task creation request.</param>
    /// <returns>The created task.</returns>
    /// <response code="201">Task created successfully.</response>
    /// <response code="400">Invalid request data.</response>
    [HttpPost]
    [ProducesResponseType(typeof(TaskResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<TaskResponse>> Create([FromBody] CreateTaskRequest request)
    {
        _logger.LogInformation("Creating task: {TaskName}", request.Name);
        
        // TODO: Implement task creation via service
        throw new NotImplementedException();
    }

    /// <summary>
    /// Gets a task by ID.
    /// </summary>
    /// <param name="id">The task ID.</param>
    /// <returns>The task details.</returns>
    /// <response code="200">Task found.</response>
    /// <response code="404">Task not found.</response>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(TaskResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TaskResponse>> GetById(string id)
    {
        _logger.LogInformation("Getting task: {TaskId}", id);
        
        // TODO: Implement task retrieval via service
        throw new NotImplementedException();
    }

    /// <summary>
    /// Lists tasks with optional filtering and pagination.
    /// </summary>
    /// <param name="status">Filter by task status.</param>
    /// <param name="from">Filter by scheduled time (from).</param>
    /// <param name="to">Filter by scheduled time (to).</param>
    /// <param name="page">Page number (default: 1).</param>
    /// <param name="pageSize">Page size (default: 20, max: 100).</param>
    /// <param name="sortBy">Sort field (scheduledTime, createdAt).</param>
    /// <param name="sortOrder">Sort order (asc, desc).</param>
    /// <returns>Paginated list of tasks.</returns>
    /// <response code="200">Tasks retrieved successfully.</response>
    [HttpGet]
    [ProducesResponseType(typeof(TaskListResponse), StatusCodes.Status200OK)]
    public async Task<ActionResult<TaskListResponse>> List(
        [FromQuery] TaskStatusEnum? status = null,
        [FromQuery] DateTime? from = null,
        [FromQuery] DateTime? to = null,
        [FromQuery] int page = 1,
        [FromQuery] int pageSize = 20,
        [FromQuery] string sortBy = "scheduledTime",
        [FromQuery] string sortOrder = "asc")
    {
        _logger.LogInformation("Listing tasks with filters - Status: {Status}, Page: {Page}", status, page);
        
        // Enforce max page size
        pageSize = Math.Min(pageSize, 100);
        
        // TODO: Implement task listing via service
        throw new NotImplementedException();
    }

    /// <summary>
    /// Updates a pending task.
    /// </summary>
    /// <param name="id">The task ID.</param>
    /// <param name="request">The update request.</param>
    /// <returns>The updated task.</returns>
    /// <response code="200">Task updated successfully.</response>
    /// <response code="404">Task not found.</response>
    /// <response code="409">Task cannot be updated (not in Pending status).</response>
    [HttpPut("{id}")]
    [ProducesResponseType(typeof(TaskResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<ActionResult<TaskResponse>> Update(string id, [FromBody] UpdateTaskRequest request)
    {
        _logger.LogInformation("Updating task: {TaskId}", id);
        
        // TODO: Implement task update via service
        throw new NotImplementedException();
    }

    /// <summary>
    /// Cancels a pending or scheduled task.
    /// </summary>
    /// <param name="id">The task ID.</param>
    /// <returns>No content on success.</returns>
    /// <response code="204">Task cancelled successfully.</response>
    /// <response code="404">Task not found.</response>
    /// <response code="409">Task cannot be cancelled (already running/completed).</response>
    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public async Task<IActionResult> Cancel(string id)
    {
        _logger.LogInformation("Cancelling task: {TaskId}", id);
        
        // TODO: Implement task cancellation via service
        throw new NotImplementedException();
    }
}
