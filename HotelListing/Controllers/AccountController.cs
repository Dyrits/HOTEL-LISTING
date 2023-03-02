using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HotelListing.Data;
using HotelListing.Models.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HotelListing.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class AccountController: ControllerBase
    {
        private readonly UserManager<User> _userManager;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;
        
        public AccountController(UserManager<User> userManager, ILogger<AccountController> logger, IMapper mapper)
        {
            _userManager = userManager;
            _logger = logger;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserDTO user)
        {
            _logger.LogInformation($"Registration attempt for {user.Email}");
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _userManager.CreateAsync(_mapper.Map<User>(user));

                if (result.Succeeded) { return Accepted(); }
                
                result.Errors.ToList().ForEach(error => ModelState.TryAddModelError(error.Code, error.Description));
                return BadRequest(ModelState);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"Something went wrong in the {nameof(Register)}");
                return Problem($"Something went wrong in the {nameof(Register)}", statusCode: 500);
            }
        }
        
        /*
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLogin user)
        {
            _logger.LogInformation($"Login attempt for {user.Email}");
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _signInManager.PasswordSignInAsync(user.Email, user.Password, false, false);
                return result.Succeeded ? Accepted() : Unauthorized();
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, $"Something went wrong in the {nameof(Login)}");
                return Problem($"Something went wrong in the {nameof(Login)}", statusCode: 500);
            }
        }
        */
    }
}