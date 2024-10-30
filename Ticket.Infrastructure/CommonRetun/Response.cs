using System.Net;

namespace Ticket.Infrastructure.CommonRetun
{
    public class Response<T>
    {
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public List<String> Errors { get; set; }
        public object Meta { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public T Data { get; set; }

    }
}
