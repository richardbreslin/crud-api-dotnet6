namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class User
{
    public int Id { get; set; }
    public string Department { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }


    public string Address { get; set; }
    public string City { get; set; }
}