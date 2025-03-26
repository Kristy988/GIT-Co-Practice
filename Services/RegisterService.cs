using Co_Practice.Models;

namespace Co_Practice.Services
{
    public class RegisterService
    {
        public bool UserRegist(RegistModel model)
        {
            UserModel userModel = new UserModel();
            userModel.Name = model.Name;
            userModel.Account = model.Account;
            userModel.Password = model.Password;
            return true;
        }
    }
}