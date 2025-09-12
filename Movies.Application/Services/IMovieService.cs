using Movies.Application.Models;

namespace Movies.Application.Services;

public interface IMovieService
{
    Task<bool> CreateAsync(Movie movie, CancellationToken token = default, Guid? userId = default);
    Task<Movie?> GetByIdAsync(Guid id, CancellationToken token = default, Guid? userId = default);
    Task<Movie?> GetBySlugAsync(string slug, CancellationToken token = default, Guid? userId = default);
    Task<IEnumerable<Movie>> GetAllAsync(CancellationToken token = default, Guid? userId = default);
    Task<Movie?> UpdateAsync(Movie movie, CancellationToken token = default, Guid? userId = default);
    Task<bool> DeleteByIdAsync(Guid id, CancellationToken token = default, Guid? userId = default);
}