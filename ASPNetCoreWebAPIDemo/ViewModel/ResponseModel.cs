namespace ASPNetCoreWebAPIDemo.ViewModel
{
    public class ResponseModel
    {
        public bool IsSuccess
        {
            get;
            set;
        }
        public string Message { get; set; }
        public string Messsage { get; internal set; }
    }
}
