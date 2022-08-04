namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class User
{
    public int Id { get; set; }
    public string Department { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}