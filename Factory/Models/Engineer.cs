using System.Collections.Generic;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.JoinEntities = new HashSet<MachineEngineer>();
    }
    
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }

    public string IsActive { get; set; }

    public virtual ICollection<MachineEngineer> JoinEntities { get; }

  }
}