using Newtonsoft.Json;
using loginSystem;
using loginSystem.Models;

class Program
  {
    
    // features to add is input sanitisation and null checking.
    // main will initalise a menu. menu shows the options
    static void Main()
    {

        // test writing of list to json file
        // for large datasets list will be inefficient but ill use mongodb later.
        // var users = new List<UserCredentials>
        // {
        //     // new UserCredentials { Username = "user1", Password = "password1" },
        //     // new UserCredentials { Username = "user2", Password = "password2" }
        // };

        // JsonParser jsonParser = new JsonParser(users);
        // dynamic jsonData = jsonParser.serializeJson();

         
        // fileManager.writeFile();

        // will use to store data in mongodb
        IDatabaseHandling database = new HandleMongoDB("");
        database.connect();

        // test reading of json from file to list and writing
        FileManager fileManager = new FileManager("data.json", Directory.GetCurrentDirectory());
        var jsonData = JsonConvert.DeserializeObject<List<UserCredentials>>(fileManager.readFile());
        List<UserCredentials> __users = new List<UserCredentials>{};
        if (jsonData != null)
        {
            __users = jsonData;
        } 
        
        HandleAuthentication session = new HandleAuthentication(__users);
        
        
        
        // test data and shit
        
        Console.Write(session.registerAttempt("user67", "password") + "\n");
        Console.Write(session.registerAttempt("user56", "password") + "\n");
        Console.Write(session.registerAttempt("user13", "password") + "\n");
        Console.Write(session.registerAttempt("user61", "password") + "\n");
        // test login 
        Console.Write($"login attempt: {session.loginAttempt("user67", "password")}\nLogged in: {session.loggedIn}\nCurrent User: {session.currentUser} \n");

        foreach (var user in session.users)
        {
            Console.WriteLine($"{user.Username}: {user.Password}\n");   
        }
        Console.WriteLine("Logout?");
        var input = Console.ReadLine();
        if (input == "yes")
        {
            session.logout();
            Console.Write($"Logged in: {session.loggedIn}\nCurrent User: {session.currentUser} \n");
        }

        JsonParser __jsonParser = new JsonParser(session.users);
        fileManager.data = __jsonParser.serializeJson();
        
        fileManager.writeFile();



        // change this to use menu class later for menu options, etc
        //HandleAuthentication.handleInput();

        // data directory
        //Console.WriteLine(loginSystem.Constants.dataDirectory);
        // current directory
        //Console.WriteLine(Directory.GetCurrentDirectory());

        
    }

  } 


