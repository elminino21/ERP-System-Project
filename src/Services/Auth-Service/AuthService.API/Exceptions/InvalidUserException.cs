using System;

namespace Newsboard.Services.AuthService.API.Error
{
    public class InvalidUserException: Exception
    {
        
        public InvalidUserException(string massage): base(massage)
        {
            
        }
    }
}