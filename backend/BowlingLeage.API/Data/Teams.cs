using System.ComponentModel.DataAnnotations;

namespace BowlingLeage.API.Data;

public class Teams
{
    [Key]
    public int TeamID { get; set; }
    public string TeamName { get; set; }
}