﻿using Application.DTOs.ApplicationUserDtos;

namespace Application.Interfaces;

public interface IIdentityService
{
    Task<LoginResult> LoginAsync(LoginUser loginUser);
    Task LogoutAsync(LogoutUser logoutUser);

    Task ChangePasswordAsync(ChangePasswordUser changePasswordUser);
    Task DeleteAccountAsync(LoginUser loginUser);
}