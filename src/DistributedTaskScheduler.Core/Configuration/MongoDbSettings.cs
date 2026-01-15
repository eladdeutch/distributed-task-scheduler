namespace DistributedTaskScheduler.Core.Configuration;

/// <summary>
/// MongoDB configuration settings.
/// </summary>
public class MongoDbSettings
{
    public const string SectionName = "MongoDB";

    /// <summary>
    /// The name of the database to use.
    /// </summary>
    public string DatabaseName { get; set; } = "task_scheduler";

    /// <summary>
    /// The name of the collection for storing tasks.
    /// </summary>
    public string TasksCollectionName { get; set; } = "tasks";

    /// <summary>
    /// The name of the collection for storing execution history.
    /// </summary>
    public string ExecutionHistoryCollectionName { get; set; } = "execution_history";
}
