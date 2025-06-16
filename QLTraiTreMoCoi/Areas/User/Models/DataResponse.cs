namespace QLTraiTreMoCoi.Areas.User.Models
{
    public class DataResponse<T>
    {
        public bool success { get; set; }
        public string message { get; set; }
        public T data { get; set; }
    }
}
