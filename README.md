# loginSystemCSharp
A login system using JSON files.
Has the Argon2 hashing algorithm for encryption.

Basic FileManager and JsonParser


# TODO:
```
Input Sanitastion
File integrity
Menu
Make a abstract class for database handling
Find a way to make it so i can translate any dataset type inside of the List<UserCredentials>
Change List<UserCredentials> which has a Big O of o(n) to a dictionary with o(1)
```


# Example usage

```
// initialise the file manager and read the existing data from json file
FileManager fileManager = new FileManager("data.json", Directory.GetCurrentDirectory());
var jsonData = JsonConvert.DeserializeObject<List<UserCredentials>>(fileManager.readFile());
List<UserCredentials> __users = new List<UserCredentials>{};
if (jsonData != null)
{
    __users = jsonData;
} 
        
HandleAuthentication session = new HandleAuthentication(__users);
        
// test data
HandleAuthentication session = new HandleAuthentication(__users);
Console.Write(session.registerAttempt("user", "password") + "\n"); // True 
Console.Write(session.loginAttempt("user", "password") + "\n"); // True 

```

# Classes I wrote:





## HandleAuthentication

HandleAuthentication takes user datasets as a List through the UserCredentials Object. This should allow me to convert any dataset into the list allowing for multiple ways to authenticate. <br><br>
Constructor: ```new(List<UserCredentials> users)```


### Parameters:

```users```: the database you want to look through



### Variables:


```bool loggedIn```: stores the if loginAttempt was successful

```string currentUser```: stores the current logged in user

### Functions:


```bool loginAttempt``` - check if the username and password are correct. returns true for success

```bool registerAttempt``` - check if the user doesn’t exist, if it doesn’t exist create it in the user list. returns true for success

```void logout``` - clears currentUser and loggedIn variables

 









## FileManager

Basic FileIO functions through parameters

Constructor: ```new(string file, string path, dynamic ?data = null)```



### Parameters:

```file```: the file you want to write or read to

```path```: the path you want to write or read to

```data```: default of null, the data you want to write



### Variables:



```string file```: file name

```string path```: path location

```dynamic data```: any type of data you want to write


### Functions:

```string readFile```- reads and returns the output of a file

```void writeFile``` - deletes the file and writes the input you want











# Classes I won’t include due to incompletion:
```
JsonParser

Menu
```
# Classes i took from other sources: 
```
Hasher
```

