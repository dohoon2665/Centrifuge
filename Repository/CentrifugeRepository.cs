using System;
using System.Threading.Tasks;
using centrifuge.Domain.Entities;
using centrifuge.Domain.Models;

namespace centrifuge.Repository
{
    public class CentrifugeRepository
    {
        private readonly CentrifugeContext _context;
        public CentrifugeRepository(CentrifugeContext context)
        {
            _context = context;
        }

        public async Task<bool> AddDoorHistory(DoorStatus newDoorStatus)
        {
            _context.DoorHistories.Add(new DoorHistory() { Status = newDoorStatus, Created = DateTime.Now });
            var result = await _context.SaveChangesAsync();
            return result == 1;
        }
    }
}