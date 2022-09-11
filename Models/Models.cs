using System.Collections.Generic;

namespace dotnet_jwt;

public record UserModel(string? Username, string? Password, string? Role);

public record UserLogin(string Username, string Password);

public class UserConstants
{
    public static IReadOnlyList<UserModel> Users = new List<UserModel>()
    {
        new UserModel("daniel", "Password1?", "admin")
    };
}