namespace centrifuge.Domain.Services
{
    public interface IDoorService
    {
        bool Open();
        bool Close();
    }
}