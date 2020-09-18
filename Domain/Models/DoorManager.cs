using System;

namespace centrifuge.Domain.Models
{

    public class DoorManager : IDoorManager
    {
        private DoorStatus _currentDoorStatus = DoorStatus.STOP;
        public DoorStatus CurrentDoorStatus { get; set; }

        public bool Close()
        {
            // TODO: Close Command
            Console.WriteLine("Close");
            return true;
        }

        public bool Open()
        {
            // TODO: Open Command
            Console.WriteLine("Open");
            return true;
        }
    }
}