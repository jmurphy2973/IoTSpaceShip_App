using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTSpaceShip_App.Model
{
  public class ShipStatus
  {
    public ShipConnect.ShipEvent PropulsionSystem { get; set; }
    public ShipConnect.ShipEvent Thrust { get; set; }
    public ShipConnect.ShipEvent DoorState { get; set; }
    public ShipConnect.ShipSample InternalTemperature { get; set; }
    public ShipConnect.ShipSample Pitch { get; set; }
    public ShipConnect.ShipSample Engine_RPM { get; set; } 
    public ShipConnect.ShipSample Engine_Temperature { get; set; }
    public ShipConnect.ShipSample Engine_Load { get; set; }
    private string IP { get; set; }
    private int PORT { get; set; }
    public ShipStatus()
    {
     
    }
  }
}
