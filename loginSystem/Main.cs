using System;
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


        // test reading of json from file to list and writing
        var fileManager = new FileManager("data.json", Directory.GetCurrentDirectory());
        
        List<UserCredentials> __users = JsonConvert.DeserializeObject<List<UserCredentials>>(fileManager.readFile());
        
        HandleAuthentication currentUser = new HandleAuthentication(__users);
        Console.Write(currentUser.registerAttempt("user67", "password") + "\n");
        Console.Write(currentUser.registerAttempt("user56", "password") + "\n");
        Console.Write(currentUser.registerAttempt("user13", "password") + "\n");
        Console.Write(currentUser.registerAttempt("user61", "password") + "\n");

        Console.Write($"login attempt: {currentUser.loginAttempt("user61", "password")} and {currentUser.loggedIn} \n");

        foreach (var user in currentUser.users)
        {
            Console.WriteLine($"{user.Username}: {user.Password}\n");   
        }

        JsonParser __jsonParser = new JsonParser(__users);
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


