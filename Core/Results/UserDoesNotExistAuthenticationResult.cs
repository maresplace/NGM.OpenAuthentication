namespace NGM.OpenAuthentication.Core.Results {
    public class UserDoesNotExistAuthenticationResult : AuthenticationResult {
        public UserDoesNotExistAuthenticationResult():base (Statuses.UserDoesNotExist) {}
    }
}