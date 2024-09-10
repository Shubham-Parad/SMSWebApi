using SMSWebApi.Models;

namespace SMSWebApi.Repo
{
    public interface AuthRepo
    {
        public void SignUp(Users u);

        public Users SignIn(Users u);
    }
}
