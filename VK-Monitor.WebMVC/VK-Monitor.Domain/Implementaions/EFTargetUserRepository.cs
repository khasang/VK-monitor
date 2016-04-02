using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain.Entities;
using VK_Monitor.Domain.Interfaces;

namespace VK_Monitor.Domain.Implementaions
{
    public class EFTargetUserRepository : ITargetUserRepository
    {
        ApplicationDbContext dbContext;

        public EFTargetUserRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<TargetUser> GetAll()
        {
            throw new NotImplementedException();
        }

        public TargetUser GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(TargetUser item)
        {
            throw new NotImplementedException();
        }

        public void Update(TargetUser item)
        {
            throw new NotImplementedException();
        }

        public void Delete(TargetUser item)
        {
            throw new NotImplementedException();
        }
    }
}
