namespace Web.Models
{
    public class ErrorViewModel : IMapFrom
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}