using Diamond.DataAccess.Models.enums;

namespace Diamond.DataAccess.Models
{
    public class Notification
    {
        public string Message { get; set; }
        public NotificationType Type { get; set; }
    }
}
