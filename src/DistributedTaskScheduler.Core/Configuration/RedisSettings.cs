namespace DistributedTaskScheduler.Core.Configuration;

/// <summary>
/// Redis configuration settings for distributed locking.
/// </summary>
public class RedisSettings
{
    public const string SectionName = "Redis";

    /// <summary>
    /// Lock expiration time in seconds.
    /// </summary>
    public int LockExpirySeconds { get; set; } = 60;

    /// <summary>
    /// Interval for renewing locks on long-running tasks.
    /// </summary>
    public int LockRenewalIntervalSeconds { get; set; } = 20;
}
