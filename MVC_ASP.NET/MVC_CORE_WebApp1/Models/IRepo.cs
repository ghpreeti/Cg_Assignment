namespace MVC_CORE_WebApp1.Models
{
    public interface IRepo<T>
    {
        bool AddData(T obj);
        bool UpadateData(int id,T obj);
        bool DeleteData(int id);

        List<T> GetAllData();
        T GetDataById(int id);

    }
}
