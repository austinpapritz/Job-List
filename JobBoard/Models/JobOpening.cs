using System.Collections.Generic;

namespace JobBoard.Models;

  public class JobOpening
  {
    public int Id { get; }
    public string Name { get; set; }
    public string Email { get; set; }

    public string PhoneNumber { get; set; }

    public string Gender { get; set; }


    public static List<JobOpening> _instances = new List<JobOpening> {};

    public JobOpening( string name, string email , string phonenumber, string gender)
    {
      Name = name;
      Email = email;
      PhoneNumber = phonenumber;
      Gender = gender;

      _instances.Add(this);
      Id = _instances.Count;
    }
    
    public static List<JobOpening> GetAll()
    {
      return _instances;
    }
    
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static void GetJobByID(int id)
    {
      // locating in List by id
      // returning the data
    }
    


  }
  