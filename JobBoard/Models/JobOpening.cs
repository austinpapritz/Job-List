using System.Collections.Generic;

namespace JobBoard.Models;

  public class JobOpening
  {
    public string Name { get; set; }
    public string Email { get; set; }
    public int IDNumber { get; set; }

    public string PhoneNumber { get; set; }


    public static List<JobOpening> _instances = new List<JobOpening> {};

    public JobOpening( string name, string email , int idnumber, string phonenumber)
    {
      Name = name;
      Email = email;
      IDNumber = idnumber;
      PhoneNumber = phonenumber;

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
  