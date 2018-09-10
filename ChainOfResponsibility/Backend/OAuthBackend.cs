namespace ChainOfResponsibility.Backend
{
    public class OAuthBackend : Backend
    {
        public new static string GetName()
        {
            return "OAUTH_BACKEND";
        }
        
        public override AuthResponse Handle(AuthRequest request)
        {
            if (request.Login == "oAuthUser" && request.Password == "oAuthPass")
            {
                return new AuthResponse(request.Login, GetName());
            }

            return base.Handle(request);
        }
    }
}