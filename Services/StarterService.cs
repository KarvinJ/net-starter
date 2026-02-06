using Starter.Models;

namespace Starter.Services;

public interface IStarterService
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    string Hello(string name);
    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<Character>> GetAll();
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

    public Task<IEnumerable<Character>> GetAll()
    {
        throw new NotImplementedException();
    }
}