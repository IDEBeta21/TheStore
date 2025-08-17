namespace EcomService.API.Models.Dto
{
    public class ServiceResponse<T>
    {
        public bool success { get; set; }
        public string message { get; set; } = string.Empty;
        public T? data { get; set; }
    }
}