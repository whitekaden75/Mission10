using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BowlingLeage.API.Data;

public class Bowlers
{
    [Key]
    public int BowlerId { get; set; }
    [Required]
    public string BowlerLastName { get; set; }
    [Required]
    public string BowlerFirstName { get; set; }
    [Required]
    public string BowlerAddress { get; set; }
    [Required]
    public string BowlerCity { get; set; }
    [Required]
    public string BowlerState { get; set; }
    [Required]
    public string BowlerZip { get; set; }
    [Required]
    public string BowlerPhoneNumber { get; set; }
    // Foreign Key
    [ForeignKey("TeamID")]
    public int TeamID { get; set; }
    public Teams Team{ get; set; }

    // // Navigation Property
    // public virtual Team Team { get; set; }
    
}