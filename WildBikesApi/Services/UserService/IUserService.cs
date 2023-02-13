﻿using WildBikesApi.DTO.User;

namespace WildBikesApi.Services.UserService
{
    public interface IUserService
    {
        Task<List<UserReadDTO>> GetAll();
        Task<UserReadDTO?> Register(UserRegisterDTO userRegisterDTO);
        Task<TokenDTO?> Login(UserLoginDTO userLoginDTO);
    }
}
