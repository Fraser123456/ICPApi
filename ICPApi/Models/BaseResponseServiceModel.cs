namespace ICPApi.Models
{
    public class BaseResponseServiceModel
    {
        public string Type { get; set; }
        public string Message { get; set; }
        public object ResponseModel { get; set; }
    }
}
