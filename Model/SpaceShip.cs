using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace IoTSpaceShip_App.Model
{

  public class Spaceship
  {
    [Required]
    [StringLength(16, ErrorMessage = "Identifier too long (16 character limit).")]
    public string Identifier { get; set; }
    public string Description { get; set; }
    public string Builder { get; set; }
    public string OriginPlanet { get; set; }

    [Required]
    public string Classification { get; set; }

    [Range(1, 100000, ErrorMessage = "Accommodation invalid (1-100000).")]
    public int MaximumOccupancy { get; set; }

    /*
    [Required]
    [Range(typeof(bool), "true", "true",
        ErrorMessage = "This form disallows unapproved ships.")]
    public bool IsValidatedDesign { get; set; }
    */
    [Required]
    public DateTime ProductionDate { get; set; }

    public double Length { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
  }

  //public enum Classification { Discovery, Defense, Deplomacy, CommandAndConquer }
}
