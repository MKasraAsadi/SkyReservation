using SkyReservation.WebAPI.Data;
using SkyReservation.WebAPI.Dtos.User;
using SkyReservation.WebAPI.Interface;

namespace SkyReservation.WebAPI.Services
{
    public class UserService : IUserService
    {
        private readonly  AppDbContext db;
        public UserService(AppDbContext db)
        {
                this.db = db;
        }
        //باید یه کلاسی درست کنم که به صورت اکستنشن باشه برای تبدیل مدل به مدل وب
        //private Void ToDTO<T> (ref T dto)
        //{


        //}
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
