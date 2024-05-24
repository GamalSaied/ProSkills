using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;

namespace ProSkills.Repository
{
    public class RedeemCodeRepository : IRepository<RedeemCode>
    {
        ITIContext context;

        // Constructor to initialize the context
        public RedeemCodeRepository(ITIContext _context)
        {
            context = _context;
        }
        // Retrieves all Data from the database
        public List<RedeemCode> GetAll() => context.RedeemCode.ToList();

        // Retrieves a Data by its ID
        public RedeemCode GetById(int id) => context.RedeemCode.FirstOrDefault(d => d.Id == id);

        // Checks if a Data with the given name exists
        public RedeemCode CheckName(string name) => context.RedeemCode.FirstOrDefault(e => e.Code.ToLower() == name.ToLower());

        // Inserts a new Data into the database
        public void Insert(RedeemCode obj) => context.Add(obj);

        // Updates Data in the database
        public void Update(RedeemCode obj) => context.Update(obj);

        // Delete Data from the database by its ID
        public void Delete(int id)
        {
            RedeemCode obj = GetById(id);
            if (obj != null)
            {
                context.Remove(obj);
            }
        }
        public void MarkAsDeleted(int id)
        {
            throw new NotImplementedException();
        }

        // Saves changes made to the database
        public void Save() => context.SaveChanges();

        public RedeemCode GetByName(string Name) => context.RedeemCode.FirstOrDefault(d => d.Code == Name);
    }
   
  
}
