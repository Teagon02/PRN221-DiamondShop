using Diamond.DataAccess.DTO;

namespace Diamond.BusinessLogic.IServices
{
    public interface IMailService
    {
        Task SendEmailAsync(MessageDto message);
    }
}
