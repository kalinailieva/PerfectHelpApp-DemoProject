

namespace PerfectData.Services.Interfaces
{
    public interface INewsletterService
    {
        void GetSubscribed(string name,string userId);

        T? GetById(object id)
    }
}
