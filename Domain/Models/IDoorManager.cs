namespace centrifuge.Domain.Models
{
    public interface IDoorManager
    {
        DoorStatus CurrentDoorStatus { get; }
        bool Open();
        bool Close();
    }
}