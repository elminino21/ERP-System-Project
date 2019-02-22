using System;

namespace Auth.API.Exceptions
{
    public class InvalidUserException: Exception
    {
        
        public InvalidUserException(string massage): base(massage)
        {
            
        }
    }
}