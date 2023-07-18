using System.Collections.Generic;

namespace JobBoard.Models;

  public class JobOpening
  {
    public string Name { get; set; }
    public static List<JobOpening> _instances = new List<JobOpening> {};

    public JobOpening( string name )
    {
      Name = name;
      _instances.Add(this);
    }
    
    public static List<JobOpening> GetAll()
    {
      return _instances;
    }
    
    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }
    


  }
  