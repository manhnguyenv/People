using System;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using People.Service.Model;
using People.Service.Options;
using People.Service.ViewModel;

namespace People.Service.Controllers
{

    [Route("api/[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly JwtIssuerOptions _jwtOptions;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            IOptions<JwtIssuerOptions> jwtOptions)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _jwtOptions = jwtOptions.Value;
        }

        public async Task<IActionResult> Login([FromBody]LoginViewModel model)
        {
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
            {
                throw new NotImplementedException();
            }

            var result = await _userManager.CheckPasswordAsync(user, model.Password);

            if (result)
            {
                var principal = await _signInManager.CreateUserPrincipalAsync(user);

                // Create the JWT security token and encode it.
                var jwt = new JwtSecurityToken(
                    issuer: _jwtOptions.Issuer,
                    audience: _jwtOptions.Audience,
                    claims: principal.Claims,
                    notBefore: _jwtOptions.NotBefore,
                    expires: _jwtOptions.Expiration,
                    signingCredentials: _jwtOptions.SigningCredentials);

                var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

                // Serialize and return the response
                var response = new
                {
                    access_token = encodedJwt,
                    expires_in = (int)_jwtOptions.ValidFor.TotalSeconds
                };


                return new JsonResult(response);
            }

            throw new NotImplementedException();
        }
        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model)
        {
            var result = await _userManager.CreateAsync(
                new ApplicationUser { UserName = model.Username, Email = model.Email },
                model.Password);
            if (!result.Succeeded)
            {
                throw new NotImplementedException();
            }

            return Ok();
        }
    }
}