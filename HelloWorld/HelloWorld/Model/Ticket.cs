using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
  public class Ticket : Flight
  {
    public string Seat { get; set; }
    public string Gate { get; set; }

    public DateTime BoardingDateTime { get; set; }

    public string Term { get; set; }
  }
}
