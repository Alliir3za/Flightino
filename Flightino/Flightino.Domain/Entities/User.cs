using System.ComponentModel.DataAnnotations;

namespace Flightino.Domain.Entities;

public class User
{
    [Key]
    public int UserId { get; set; }
}

