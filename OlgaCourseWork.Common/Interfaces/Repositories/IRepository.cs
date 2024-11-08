
namespace OlgaCourseWork.Common.Interfaces.Repositories
{
	public interface IRepository<T> where T : class
	{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(Guid id);
		Task<int> AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(Guid id);
	}
}
