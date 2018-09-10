namespace ChainOfResponsibility
{
    public class AuthResponse
    {
        public string UserName;
        public string BackendName;

        public AuthResponse(string userName, string backendName)
        {
            UserName = userName;
            BackendName = backendName;
        }
    }
}