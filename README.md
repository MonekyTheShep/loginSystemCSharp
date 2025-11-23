# loginSystemCSharp
A login system using JSON files.
Has the Argon2 hashing algorithm for encryption.

Basic FileManager and JsonParser


# TODO:
```
Input Sanitastion
Menu
Make a abstract class for database handling
Find a way to make it so i can translate any dataset type inside of the List<UserCredentials>
```



# Classes I wrote:





## HandleAuthenticator

HandleAuthenticator takes user datasets as a List through the UserCredentials Object. This should allow me to convert any dataset into the list allowing for multiple ways to authenticate. <br>
Constructor: ```new(List<UserCredentials> users)```


### Parameters:

```users```: the database you want to look through



### Variables:


```bool loggedIn```: stores the if loginAttempt was successful

```string currentUser```: stores the current logged in user

### Functions:


```loginAttempt``` - check if the username and password are correct

```registerAttempt``` - check if the user doesn’t exist, if it doesn’t exist create it in the user list

 









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

```readFile```- reads and returns the output of a file

```writeFile``` - deletes the file and writes the input you want











# Classes I won’t include due to incompletion:
```
JsonParser

Menu
```
# Classes i took from other sources: 
```
Hasher
```