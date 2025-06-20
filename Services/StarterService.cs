using Starter.Models;

namespace Starter.Services;

public interface IStarterService
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    string Hello(string name);
}

/// <inheritdoc />
public class StarterService : IStarterService
{
    /// <summary>
    /// 
    /// </summary>
    public StarterService()
    {
    }

    /// <inheritdoc />
    public string Hello(string name)
    { 
       return $"Hello, {name}";
    }
}