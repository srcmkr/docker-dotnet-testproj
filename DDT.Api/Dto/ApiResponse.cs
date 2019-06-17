namespace DDT.Api.Dto
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public object Object { get; set; }
        public string Error { get; set; }
    }
}
