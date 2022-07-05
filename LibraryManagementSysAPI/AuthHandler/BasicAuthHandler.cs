using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace LibraryManagementSysAPI.AuthHandler
{
    public class BasicAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    // inside the placeholder we are telling the authentication handler that which type of scheme that we are going to use 
    {

        public BasicAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder, ISystemClock clock)
            : base(options, logger, encoder, clock)
        {
        }
        //we are using async here to handle the request asynchronously
        protected override Task<AuthenticateResult> HandleAuthenticateAsync()
        //whenever a request need authentication this method will get called 
        {
            ///// if we have the authorization tag in the header then

            return Task.FromResult(AuthenticateResult.Fail("Need To implement"));
        }

    }
}
