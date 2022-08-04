namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateRequest
{
    public string Department { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

}