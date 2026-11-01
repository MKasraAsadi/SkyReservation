using SkyReservation.WebAPI.Dtos.User;
using SkyReservation.WebAPI.Interface;

namespace SkyReservation.WebAPI.Services
{
    public class UserService : IUserService
    {
        public Task<AddUserResponse> AddUser(AddUserRequest item)
        {
            throw new NotImplementedException();
        }

        public Task<AddUserResponse> DeleteUser(int itemID)
        {
            throw new NotImplementedException();
        }

        public Task<List<AddUserResponse>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<AddUserResponse> GetUser(int itemID)
        {
            throw new NotImplementedException();
        }

        public Task<AddUserResponse> UpdateUser(AddUserRequest item)
        {
            throw new NotImplementedException();
        }
    }
}
