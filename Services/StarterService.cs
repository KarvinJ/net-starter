using Microsoft.EntityFrameworkCore;
using Starter.Helpers;
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
    private readonly DataContext _context;
    /// <summary>
    /// 
    /// </summary>
    public StarterService(DataContext context)
    {
        _context = context;
    }

    /// <inheritdoc />
    public string Hello(string name)
    { 
       return $"Hello, {name}";
    }

    public async Task<IEnumerable<Character>> GetAll()
    {
        return await _context.Characters.ToListAsync();
    }
}