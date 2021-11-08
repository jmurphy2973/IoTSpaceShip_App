using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IoTSpaceShip_App.Model.ShipConnect
{
  public class ShipSample
  {
    private string DataItemId { get; set; }
    public string Name { get; set; }
    public DateTime TimeStampUtc { get; set; }
    public double Value { get; set; }
    private long Sequence { get; set; }
    public ShipSample() { }

  }
}
