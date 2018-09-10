namespace ChainOfResponsibility.Backend
{
    public class Backend
    {
        public static string GetName()
        {
            return "NO_AUTH";  
        } 
        
        public Backend Next  { set; get; }

        public virtual AuthResponse Handle(AuthRequest request)
        {
            return Next != null ? Next.Handle(request) : new AuthResponse("Unknown", GetName());
        }
    }
}