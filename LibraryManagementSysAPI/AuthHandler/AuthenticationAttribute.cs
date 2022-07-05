using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSysAPI.AuthHandler
{
    public class AuthenticationAttribute : TypeFilterAttribute
    {
        public AuthenticationAttribute(string actionName, string roleType) : base(typeof(AuthorizeAction))
        {
            Arguments = new object[]
            {
                actionName,
                roleType
            };
        }

    }
}
