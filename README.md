# loginSystemCSharp
A login system using JSON files.
Has the Argon2 hashing algorithm for encryption.

Basic FileManager and JsonParser







# Classes I wrote:





## HandleAuthenticator

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