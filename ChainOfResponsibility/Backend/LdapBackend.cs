namespace ChainOfResponsibility.Backend
{
    public class LdapBackend : Backend
    {
        public new static string GetName()
        {
            return "LDAP_BACKEND";
        }
        
        public override AuthResponse Handle(AuthRequest request)
        {
            if (request.Login == "ldapUsername" && request.Password == "ldapPassword")
            {
                return new AuthResponse(request.Login, GetName());
            }

            return base.Handle(request);
        }
    }
}