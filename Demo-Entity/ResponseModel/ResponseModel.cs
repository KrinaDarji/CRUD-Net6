namespace Demo.Entities.ResponseModel
{
    public class ResponseModel<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string Message { get; set; }
        public int StatusCode { get; set; }

    }
}
