using System;
using System.Collections.Generic;
using ChainOfResponsibility;
using ChainOfResponsibility.Backend;
using Xunit;

namespace ChainOfResponsibilityTest
{
    public class ProgramTest
    {
        private static Backend GetBackend()
        {
            return new LdapBackend {Next = new OAuthBackend{Next = new ApiBackend() } };
        }
        
        [Fact]
        public void LdapAuthTest()
        {
            var auth = new Authenticator(GetBackend());

            var resp = auth.Authorize(new AuthRequest("ldapUsername", "ldapPassword"));

            Assert.Equal(LdapBackend.GetName(), resp.BackendName);
        }

        [Fact]
        public void OauthAuthTest()
        {
            var auth = new Authenticator(GetBackend());

            var resp = auth.Authorize(new AuthRequest("oAuthUser", "oAuthPass"));

            Assert.Equal(OAuthBackend.GetName(), resp.BackendName);
        }
        
        
        [Fact]
        public void ApiAuthTest()
        {
            var auth = new Authenticator(GetBackend());

            var resp = auth.Authorize(new AuthRequest("apiUser", "apiPass"));

            Assert.Equal(ApiBackend.GetName(), resp.BackendName);
        }

        [Fact]
        public void EmptyAuthTest()
        {
            var auth = new Authenticator(GetBackend());

            var resp = auth.Authorize(new AuthRequest("", ""));

            Assert.Equal(Backend.GetName(), resp.BackendName);
            
        }
    }
}