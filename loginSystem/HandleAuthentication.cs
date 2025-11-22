using loginSystem.Models;
namespace loginSystem
{
  public class HandleAuthentication
    {
      // add which user in the database your logged into later

      public List<UserCredentials> users = new List<UserCredentials>{};
      public bool loggedIn = false;
      public string currentUser;
      PasswordHasher passwordHasher = new PasswordHasher();

      /// <summary>login to a user through the class.</summary>
      /// <param name="users">The database you want to look through.</param>
      public HandleAuthentication(List<UserCredentials> users)
      {
        this.users = users;      
      }

      // check user exists in the data if not create the user.
      public bool registerAttempt(string _user, string _password)
      {
        
        bool userExists = false;
        foreach (var user in users)
        {
          if (user.Username == _user)
          {
              userExists = true;  
              break;    
          }       
        }

        if (userExists == false)
        {
          var hashedPassword = passwordHasher.HashPassword(_password);
          users.Add(new UserCredentials { Username = _user, Password = hashedPassword }); 
          return true; 
        }
        return false;
      }

      // check if the username and password is correct. return true if found correct username/password. return false if not.
      public bool loginAttempt(string _user, string _password)
      {
        
        string foundPassword = null;
        foreach (var user in users)
          {
            
            if (user.Username == _user)
              {
                foundPassword = user.Password;
                break;
              }
              
          } 

          if (foundPassword != null)
          {
                var verifyHash = passwordHasher.VerifyPassword(_password, foundPassword);
                if (verifyHash)
                {

                currentUser = _user;
                loggedIn = true;
                return true;
                }
          }
        return false;
      }
      
    } 
}

