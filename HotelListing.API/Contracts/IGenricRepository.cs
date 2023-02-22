namespace HotelListing.API.Contracts
{
    public interface IGenricRepository<T> where T: class
    {
        Task<T> GetAsyn(int? id);
        Task<List<T>> GetAllAsynsc();
        Task<T> AddAsynsc(T entity);
        Task DeleteAsynsc(int id);
        Task UpdateAsynsc(T entity);
        Task<bool> Exists(int id);

    }
    }
