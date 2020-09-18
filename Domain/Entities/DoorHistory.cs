using System;
using centrifuge.Domain.Models;

namespace centrifuge.Domain.Entities
{
    public class DoorHistory
    {
        public int DoorHistoryId { get; set; }
        public DoorStatus Status { get; set; }
        public DateTime Created { get; set; }
    }
}