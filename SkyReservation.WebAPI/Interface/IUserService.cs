using SkyReservation.WebAPI.Dtos.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace SkyReservation.WebAPI.Interface;
public interface IUserService
{
    Task<AddUserResponse> AddUser(AddUserRequest item);
    Task<AddUserResponse> GetUser(int itemID);
    Task<AddUserResponse> UpdateUser(AddUserRequest item);
    Task<AddUserResponse> DeleteUser(int itemID);
    Task<List<AddUserResponse>> GetAllUser();
}
