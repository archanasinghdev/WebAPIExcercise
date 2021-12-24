using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace API.SeedWork
{
    public static class UserServiceAPIErrors
    {
        public static NotFoundObjectResult RecordNotFound
        {
            get
            {
                var problemDetails = new ProblemDetails
                {
                    Status = (int)HttpStatusCode.NotFound,
                    Type = "https://httpstatuses.com/404",
                    Title = "Record not found",
                    Detail = "No record exist in database with specified Id. Please try again using valid Id",
                };

                return new NotFoundObjectResult(problemDetails);
            }
        }
    }
}
