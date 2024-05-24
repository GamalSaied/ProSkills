namespace ProSkills.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        T GetByName(string id);
        T CheckName(string name);
        void Insert(T obj);
        void Update(T obj);
        void Delete(int id);
        void Save();
        void MarkAsDeleted(int id);  // Add this method
    }
}
