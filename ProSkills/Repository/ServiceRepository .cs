using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

public class ServiceRepository : IRepository<Service>, IServiceRepository
{
    ITIContext context;

    public ServiceRepository(ITIContext _context)
    {
        context = _context;
    }

    public List<Service> GetAll()
    {
        return context.Service.ToList();
    }

    public Service GetById(int id)
    {
        var service = context.Service.FirstOrDefault(d => d.Id == id);
        if (service == null)
        {
            throw new KeyNotFoundException($"Service with Id {id} not found.");
        }
        return service;
    }

    public Service GetByName(string name)
    {
        var service = context.Service.FirstOrDefault(d => d.Name == name);
        if (service == null)
        {
            throw new KeyNotFoundException($"Service with Name '{name}' not found.");
        }
        return service;
    }

    public Service CheckName(string name)
    {
        var service = context.Service.FirstOrDefault(e => e.Name.ToLower() == name.ToLower());
        if (service == null)
        {
            throw new KeyNotFoundException($"Service with Name '{name}' not found.");
        }
        return service;
    }

    public void Insert(Service obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(nameof(obj), "Service cannot be null.");
        }
        context.Add(obj);
    }

    public void Update(Service obj)
    {
        if (obj == null)
        {
            throw new ArgumentNullException(nameof(obj), "Service cannot be null.");
        }
        context.Update(obj);
    }

    public void Delete(int id)
    {
        Service obj = GetById(id);
        if (obj != null)
        {
            context.Remove(obj);
        }
    }

    public void Save() => context.SaveChanges();

    public void MarkAsDeleted(int id)
    {
        var service = GetById(id);
        if (service != null)
        {
            service.IsDeleted = true;
            Update(service);
        }
    }
}
