namespace WebApi.Models.Users;

using System.ComponentModel.DataAnnotations;
using WebApi.Entities;

public class UpdateRequest
{
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    [EnumDataType(typeof(Role))]
    public string Role { get; set; }

}