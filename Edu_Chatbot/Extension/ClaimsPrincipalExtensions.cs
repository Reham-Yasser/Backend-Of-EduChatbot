﻿using System.Security.Claims;

namespace Edu_Chatbot.Extension
{
    public static class ClaimsPrincipalExtensions 
    {

        public static string RetrieveEmailFromPrincipal(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.Email);
        }

    }
}
