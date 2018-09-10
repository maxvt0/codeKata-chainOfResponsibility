namespace ChainOfResponsibility
{
    public class Authenticator
    {
        private Backend.Backend _backend;
        
        public Authenticator(Backend.Backend backend)
        {
            _backend = backend;
        }

        public AuthResponse Authorize(AuthRequest request)
        {
            return _backend.Handle(request);
        }
    }
}