using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Internal;
using SpotOps.Api.Models;
using LoginModel = SpotOps.Api.Models.LoginModel;
using RegisterModel = SpotOps.Api.Models.RegisterModel;

namespace SpotOps.Api.Services.Interfaces;

public interface IUserService
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task<string> RegisterAsync(RegisterModel model);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    //Task<AuthenticationModel> GetTokenAsync(TokenRequestModel model);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task<string> AddRoleAsync(AddRoleModel model);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    Task <AuthenticationModel> LoginAsync(LoginModel model);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<ApplicationUser?> GetUserFromJwtAsync(string jwt);

    Task<string> LogoutAsync(LogoutModel model);
}