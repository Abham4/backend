namespace firstnet.Domain.Model;
public class Staff:BaseModel {
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public DateTime RegistrationDate { get; set; }
    public Member Member { get; set;}
    public int MemberId { get; set; }
}