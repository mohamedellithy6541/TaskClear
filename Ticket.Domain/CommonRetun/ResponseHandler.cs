using Ticket.Domain.CommonRetun;

namespace Ticket.Infrastructure.CommonRetun
{
    public class ResponseHandler
    {
        public ResponseHandler()
        {
        }
        public Response<T> Created<T>()
        {
            return new Response<T>
            {

                Succeeded = true,
                Message = "Created",
                StatusCode = System.Net.HttpStatusCode.Created,

            };
        }
        public Response<T> Success<T>(T entity)
        {
            return new Response<T>
            {
                Data = entity,
                Succeeded = true,
                Message = "success",
                StatusCode = System.Net.HttpStatusCode.OK,

            };
        }
        public Response<T> NotFound<T>()
        {
            return new Response<T>
            {
                Succeeded = false,
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Message = "Not Found"
            };
        }
        public Response<T> EditSuccess<T>()
        {
            return new Response<T>
            {
                Succeeded = true,
                Message = "Updated",
                StatusCode = System.Net.HttpStatusCode.OK,

            };
        }
        public Response<T> Deleted<T>()
        {
            return new Response<T>
            {
                Succeeded = true,
                Message = "Deleted",
                StatusCode = System.Net.HttpStatusCode.OK,
            };
        }
        public Response<T> BadRequest<T>(string message)
        {
            return new Response<T>
            {
                Succeeded = false,
                Message = message ?? "Bad Request",
                StatusCode = System.Net.HttpStatusCode.BadRequest,
            };

        }
    }
}
