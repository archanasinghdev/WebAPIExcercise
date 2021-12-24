using System;
using System.Collections.Generic;

namespace Application.SeedWork.CustomExceptions
{
    public class InvalidRequestException : Exception
    {
        public List<string> Errors { get; }

        public InvalidRequestException(List<string> errors)
        {
            Errors = errors;
        }
    }
}
