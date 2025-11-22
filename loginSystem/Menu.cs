namespace menuSystem
{
class Menu
  {
    public string[] ?menuOptions;
    public string[] ?userInput;

    // will use this to do menu options and looping.


    /// <summary>create a console menu</summary>
    public Menu(string [] ?menuOptions, string[] ?userInput)
    {
        this.menuOptions = menuOptions;
        this.userInput = userInput;
    }
    public string takeInput()
    {
        bool correctInput = false;

        while (!correctInput) {
            
            string input = Console.ReadLine();
            if (input != null){
                return input;        
            }
        }
        return "";
    }
  }
}

