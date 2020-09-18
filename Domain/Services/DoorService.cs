using centrifuge.Domain.Models;

namespace centrifuge.Domain.Services
{

    public class DoorService : IDoorService
    {
        private readonly IDoorManager _doormanager;

        public DoorService(IDoorManager doorManager)
        {
            _doormanager = doorManager;
        }


        public bool Open()
        {
            // TODO: Store LOG in database
            return _doormanager.Open();
        }

        public bool Close()
        {
            // TODO: Store LOG in database
            return _doormanager.Close();

        }
    }
}