namespace ChainOfResponsibility.Backend
{
    public class ApiBackend : Backend
    {
        public new static string GetName()
        {
            return "API_BACKEND";
        }
        
        public override AuthResponse Handle(AuthRequest request)
        {
            if (request.Login == "apiUser" && request.Password == "apiPass")
            {
                return new AuthResponse(request.Login, GetName());
            }

            return base.Handle(request);
        }
    }
}