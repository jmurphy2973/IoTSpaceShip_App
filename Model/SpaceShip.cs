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

    /*
    [Required]
    [Range(typeof(bool), "true", "true",
        ErrorMessage = "This form disallows unapproved ships.")]
    public bool IsValidatedDesign { get; set; }
    */
    [Required]
    public DateTime ProductionDate { get; set; }
    public string ZipCode { get; set; }
    public double Gps_N { get; set; }  = 86.3994;
    public double Gps_W { get; set; } = 39.7042;
    public double Velocity { get; set; }
    //public double Pitch { get; set; }
    //public ShipStatus Status { get; set; }
  }

  //public enum Classification { Discovery, Defense, Deplomacy, CommandAndConquer }
}
