using Maktabaty.Application.ResponseContracts;
using Maktabaty.Application.RequestContracts;
using Maktabaty.Custom_Attributes;
using Maktabaty.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Maktabaty.Web.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.Select(u => new UserResponse
            {
                Id = u.Id,
                UserName = u.UserName!,
                Email = u.Email!,
                PhoneNumber = u.PhoneNumber!,
                IsLockedOut = u.LockoutEnabled && u.LockoutEnd > DateTimeOffset.UtcNow
            })
            .AsNoTracking()
            .ToListAsync();

            return View(users);
        }

        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Add()
        {
            var response = new CreateUserResponse
            {
                SelectRoles = _roleManager.Roles.Select(r => new SelectListItem
                {
                    Value = r.Name!,
                    Text = r.Name!
                }).ToList()
            };

            return PartialView("_Form", response);
        }

        [HttpPost]
        [AjaxOnly]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(CreateUserResponse request)
        {
            if (!ModelState.IsValid)
            {
                request.SelectRoles = _roleManager.Roles.Select(r => new SelectListItem
                {
                    Value = r.Name!,
                    Text = r.Name!
                }).ToList();
                return PartialView("_Form", request);
            }

            var user = new ApplicationUser
            {
                UserName = request.UserName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                request.SelectRoles = _roleManager.Roles.Select(r => new SelectListItem
                {
                    Value = r.Name!,
                    Text = r.Name!
                }).ToList();
                return PartialView("_Form", request);
            }

            if (request.Roles != null && request.Roles.Any())
            {
                await _userManager.AddToRolesAsync(user, request.Roles);
            }

            return Json(new
            {
                success = true,
                user = new
                {
                    id = user.Id,
                    userName = user.UserName,
                    email = user.Email,
                    phoneNumber = user.PhoneNumber
                }
            });
        }

        [HttpGet]
        [AjaxOnly]
        public async Task<IActionResult> Edit(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            var response = new CreateUserResponse
            {
                Id = user.Id,
                UserName = user.UserName!,
                Email = user.Email!,
                PhoneNumber = user.PhoneNumber!,
                Roles = (await _userManager.GetRolesAsync(user)).ToList(),
                SelectRoles = _roleManager.Roles.Select(r => new SelectListItem
                {
                    Value = r.Name!,
                    Text = r.Name!
                }).ToList()
            };

            return PartialView("_Form", response);
        }

        [HttpPost]
        [AjaxOnly]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(CreateUserResponse request)
        {
            ModelState.Remove(nameof(CreateUserResponse.Password));

            if (!ModelState.IsValid)
            {
                request.SelectRoles = _roleManager.Roles.Select(r => new SelectListItem
                {
                    Value = r.Name!,
                    Text = r.Name!
                }).ToList();
                return PartialView("_Form", request);
            }

            var user = await _userManager.FindByIdAsync(request.Id);
            if (user == null)
            {
                return NotFound();
            }

            user.UserName = request.UserName;
            user.Email = request.Email;
            user.PhoneNumber = request.PhoneNumber;

            var updateResult = await _userManager.UpdateAsync(user);
            if (!updateResult.Succeeded)
            {
                foreach (var error in updateResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                request.SelectRoles = _roleManager.Roles.Select(r => new SelectListItem
                {
                    Value = r.Name!,
                    Text = r.Name!
                }).ToList();
                return PartialView("_Form", request);
            }

            var existingRoles = await _userManager.GetRolesAsync(user);
            var requestedRoles = request.Roles ?? new List<string>();

            var rolesToRemove = existingRoles.Except(requestedRoles).ToList();
            var rolesToAdd = requestedRoles.Except(existingRoles).ToList();

            if (rolesToRemove.Count > 0)
            {
                await _userManager.RemoveFromRolesAsync(user, rolesToRemove);
            }

            if (rolesToAdd.Count > 0)
            {
                await _userManager.AddToRolesAsync(user, rolesToAdd);
            }

            return Json(new
            {
                success = true,
                user = new
                {
                    id = user.Id,
                    userName = user.UserName,
                    email = user.Email,
                    phoneNumber = user.PhoneNumber
                }
            });
        }

        [HttpGet]
        public async Task<IActionResult> CheckUniqueUserName(string userName, string? id)
        {
            var exists = await _userManager.Users
                .AnyAsync(u => u.UserName == userName && u.Id != id);

            return Json(!exists);
        }

        [HttpGet]
        public async Task<IActionResult> CheckUniqueEmail(string email, string? id)
        {
            var exists = await _userManager.Users
                .AnyAsync(u => u.Email == email && u.Id != id);

            return Json(!exists);
        }

        [HttpPost]
        [AjaxOnly]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ToggleLockUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            if (!user.LockoutEnabled)
            {
                user.LockoutEnabled = true;
                await _userManager.UpdateAsync(user);
            }

            var isLockedOut = await _userManager.IsLockedOutAsync(user);
            DateTimeOffset? lockoutEnd = isLockedOut ? null : DateTimeOffset.UtcNow.AddYears(100);

            await _userManager.SetLockoutEndDateAsync(user, lockoutEnd);

            // invalidate current login sessions to log out the user immediately if they are currently logged in
            await _userManager.UpdateSecurityStampAsync(user);

            return Json(new { success = true, isLockedOut = !isLockedOut });
        }
    }
}
