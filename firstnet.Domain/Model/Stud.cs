namespace firstnet.Domain.Model;
public class Stud:BaseModel {
  public User User{ get; set;}
  public  string FirstName { get; set; }
  public string MiddleName { get; set; }
  public string LastName { get; set; }

}