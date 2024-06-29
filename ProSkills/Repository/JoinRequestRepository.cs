using Microsoft.EntityFrameworkCore;
using ProSkills.Interfaces;
using ProSkills.Models.ClientSide;
using System.Collections.Generic;
using System.Linq;

namespace ProSkills.Repository
{
    public class JoinRequestRepository : IJoinRequestRepository
    {
        private readonly ITIContext _context;

        public JoinRequestRepository(ITIContext context)
        {
            _context = context;
        }
        public List<JoinRequest> GetAll()
        {
            return _context.JoinRequests
                .Include(jr => jr.Course)
                .Include(jr => jr.Trainee)
                .ToList();
        }
        public JoinRequest GetById(int id)
        {
            return _context.JoinRequests
                .Include(jr => jr.Course)
                .Include(jr => jr.Trainee)
                .FirstOrDefault(jr => jr.Id == id);
        }

        public JoinRequest GetByName(string id)
        {
            throw new NotImplementedException();
        }

        public JoinRequest CheckName(string name)
        {
            throw new NotImplementedException();
        }

        public void Insert(JoinRequest joinRequest)
        {
            _context.JoinRequests.Add(joinRequest);
        }

        public void Update(JoinRequest joinRequest)
        {
            _context.JoinRequests.Update(joinRequest);
        }

        public void Delete(int id)
        {
            var joinRequest = GetById(id);
            if (joinRequest != null)
            {
                _context.JoinRequests.Remove(joinRequest);
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void MarkAsDeleted(int id)
        {
            var joinRequest = GetById(id);
            if (joinRequest != null)
            {
                joinRequest.IsDeleted = true;
                Update(joinRequest);
                Save();
            }
        }
    }
}
