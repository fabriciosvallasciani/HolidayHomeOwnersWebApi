using Repositories.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace HolidayHomesOwnersWebApi.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private IUsersRepository _usersRepository;

        public BasicAuthenticationHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IUsersRepository usersRepository)
            : base(options, logger, encoder, clock)
        {
            _usersRepository = usersRepository ??
                throw new ArgumentNullException(nameof(usersRepository));
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            bool authorizationHeaderFound = AuthenticationHeaderValue.TryParse(Request.Headers["Authorization"], out AuthenticationHeaderValue authorizationHeaderValue);
            if (!authorizationHeaderFound)
            {
                return AuthenticateResult.Fail("Authorization header not found.");
            }

            var bytes = Convert.FromBase64String(authorizationHeaderValue.Parameter);
            string[] credentials = Encoding.UTF8.GetString(bytes).Split(':');
            string emailAddress = credentials[0];
            string password = credentials[1];

            bool authorizationOk = await _usersRepository.Authorize(emailAddress, password);
            
            if(authorizationOk)
            {
                var claims = new[] {new Claim(ClaimTypes.Name, emailAddress)};
                var identity = new ClaimsIdentity(claims, Scheme.Name);
                var principal = new ClaimsPrincipal(identity);
                var ticket = new AuthenticationTicket(principal, Scheme.Name);

                return AuthenticateResult.Success(ticket);
            }
            else 
            {
                return AuthenticateResult.Fail("Error has occured");
            }
        }
    }
}
