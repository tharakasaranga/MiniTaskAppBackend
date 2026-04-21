using FirebaseAdmin.Auth;

namespace backend.Services
{
    public class FirebaseAuthService
    {
        public async Task<string?> VerifyTokenAndGetUserIdAsync(string token)
        {
            try
            {
                var decodedToken = await FirebaseAuth.DefaultInstance.VerifyIdTokenAsync(token);
                return decodedToken.Uid;
            }
            catch
            {
                return null;
            }
        }
    }
}