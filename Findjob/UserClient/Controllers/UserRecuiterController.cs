﻿using FindJobSolution.APItotwoweb.API;
using FindJobSolution.Data.EF;
using FindJobSolution.ViewModels.Catalog.Jobs;
using FindJobSolution.ViewModels.Catalog.JobSeekers;
using FindJobSolution.ViewModels.Catalog.Recruiters;
using FindJobSolution.ViewModels.System.User;
using FindJobSolution.ViewModels.System.UsersRecruiter;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FindJobSolution.WebApp.Controllers
{
    public class UserRecuiterController : Controller
    {
        private readonly IUserAPI _userAPI;
        private readonly IConfiguration _configuration;
        private readonly IRecuiterAPI _recuiterAPI;
        private readonly IHttpContextAccessor _httpContextAccessor;
        //private Guid idUser;

        public UserRecuiterController(IUserAPI userAPI, IConfiguration configuration, IRecuiterAPI recuiterAPI, IHttpContextAccessor httpContextAccessor)
        {
            _userAPI = userAPI;
            _configuration = configuration;
            _recuiterAPI = recuiterAPI;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<IActionResult> Index()
        {
            var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var data = await _recuiterAPI.GetByUserId(userId);
            return View(data);
        }

        public async Task<IActionResult> IndexRecuiter(int id)
        {
            var data = await _recuiterAPI.GetById(id);
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginRequest request)
        {
            if (ModelState.IsValid)
            {
                return View(new UserLoginRequest());
                //return View();
            }

            var token = await _userAPI.Authencate(request);
            if (token == null)
            {
                return RedirectToAction("Login", "UserRecuiter");
            }
            var userPrincipal = this.ValidateToken(token);

            IEnumerable<Claim> claims = userPrincipal.Claims;

            var role = claims.FirstOrDefault(x => x.Type == ClaimTypes.Role).Value;

            if (role.Contains("Recuiter"))
            {
                var authProperties = new AuthenticationProperties
                {
                    ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30),
                    IsPersistent = false
                };
                HttpContext.Session.SetString("Token", token);
                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    userPrincipal,
                    authProperties);
                return RedirectToAction("IndexRecuiter", "Home");
            }
            else
            {
                ModelState.AddModelError("", "You are not a Recuiter");
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            HttpContext.Session.Remove("Token");
            return RedirectToAction("IndexRecuiter", "Home");
        }

        private ClaimsPrincipal ValidateToken(string jwtToken)
        {
            IdentityModelEventSource.ShowPII = true;

            SecurityToken validatedToken;
            TokenValidationParameters validationParameters = new TokenValidationParameters();

            validationParameters.ValidateLifetime = true;

            validationParameters.ValidAudience = _configuration["Tokens:Issuer"];
            validationParameters.ValidIssuer = _configuration["Tokens:Issuer"];

            validationParameters.IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));

            ClaimsPrincipal principal = new JwtSecurityTokenHandler().ValidateToken(jwtToken, validationParameters, out validatedToken);

            return principal;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterRecuiterRequest request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _recuiterAPI.Register(request);
            if (result)
            {
                TempData["result"] = "Create recuiter successfully";
                return RedirectToAction("Login");
            }
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _recuiterAPI.GetById(id);
            if (result != null)
            {
                var user = result;
                var updateRequest = new RecruiterUpdateRequest()
                {
                    CompanyName = user.CompanyName,
                    Address = user.Address,
                    CompanyIntroduction = user.CompanyIntroduction,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                };
                return View(updateRequest);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<IActionResult> Edit(int id, [FromForm] RecruiterUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _recuiterAPI.Edit(id, request);
            if (result)
            {
                TempData["result"] = "Cập nhật người dùng thành công";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result.ToString());
            return View(request);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRecuiter(string keyWord, int pageIndex = 1, int pageSize = 5)
        {
            var request = new GetRecuiterPagingRequest()
            {
                keyword = keyWord,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _recuiterAPI.GetAllPagingRecuiter(request);
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> ChangePassword(int id)
        {
            //if (!User.Identity.IsAuthenticated)
            //    return RedirectToAction("index", "Home");

            var userName = User.Identity.Name;

            var result = await _recuiterAPI.GetById(id);
            if (result != null)
            {
                var updateRequest = new ChangePasswordModel()
                {
                    UserName = userName,
                };
                return View(updateRequest);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel request)
        {
            if (!ModelState.IsValid)
                return View();

            var data = await _userAPI.ChangePassword(request);
            if (data)
            {
                TempData["result"] = "Cập nhật mật khẩu thành công";
                return RedirectToAction("index", "UserRecuiter");
            }

            ModelState.AddModelError("", data.ToString());
            return View(request);
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(SendMailModel request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _recuiterAPI.ForgotPassword(request.Email);
            if (!result)
            {
                TempData["result"] = "Gửi mail không thành công";
                return View();
            }

            return RedirectToAction("Login", "UserRecuiter");
        }

        [HttpGet]
        public IActionResult ChangePasswordWithToken()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePasswordWithToken(ResetPasswordVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var result = await _userAPI.ChangePasswordWithToken(request);
            if (!result)
            {
                TempData["result"] = "Đổi mật khẩu không thành công";
                return View();
            }

            return RedirectToAction("Login", "UserRecuiter");
        }
    }
}