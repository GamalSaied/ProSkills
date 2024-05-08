namespace ProSkills.Interfaces
{
    public interface IRepository<T>
    {
            // Retrieves all items of type T from the repository.
            List<T> GetAll();

            // Retrieves an item of type T by its unique identifier.
            T GetById(int id);

            // Checks if an item with the specified name exists in the repository and returns it.
            T CheckName(string name);

            // Inserts a new item of type T into the repository.
            void Insert(T obj);

            // Updates an existing item of type T in the repository.
            void Update(T obj);

            // Deletes an item of type T from the repository by its unique identifier.
            void Delete(int id);

            // Saves any changes made to the repository.
            void Save();
    }
}
