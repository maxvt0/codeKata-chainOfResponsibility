namespace ChainOfResponsibility
{
    public class AuthRequest
    {
        public string Login;
        public string Password;

        public AuthRequest(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}