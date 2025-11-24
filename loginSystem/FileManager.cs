namespace loginSystem
{
    class FileManager
  {
    
    // add file integrity later

    
    public string file;
    public string path;
    public dynamic ?data;


    /// <summary>pass file data and stuff.</summary>
    /// <param name="file">The file to process.</param>
    /// <param name="path">The path you want to read or write to.</param>
    /// <param name="data">The data you want to write to the file</param>
    public FileManager(string file, string path, dynamic ?data = null)
    {
        this.file = file;
        this.path = path;
        this.data = data;
        
    }
    public void writeFile()
    {
        string fullPath = Path.Combine(path, file);

        // delete the file if it does exist to rewrite it
        if (File.Exists(fullPath))
            {
                File.Delete(fullPath);
            }

        // try writing data to the file
        try
          {
            using (StreamWriter sw = File.CreateText(fullPath))
              {
                sw.WriteLine(data);
              }
          }
          catch (Exception e)
          {
            Console.WriteLine(e.ToString(), "An error occured writing the file");
            throw;  
          }

          
    }
    
    public string readFile()
    {
      string fullPath = Path.Combine(path, file);
      if (File.Exists(fullPath)){
        try
        {
          var fileData = File.ReadAllText(fullPath); 
          if (fileData != null)
          {
            return fileData;  
          }
                  
        }
        catch (Exception e)
        {
          Console.WriteLine(e.ToString(), "An error occured reading the file");
          throw;            
        }
        
      } 
      return ""; 
      
        
    }

  }
}

