using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models;

public class Machine 
{
  public int MachineId{get; set;}
  [Required(ErrorMessage="Machine name cannot be empty")]
  public string Name {get; set;}

  public List<MachineEngineer> JoinEntities {get; set;}
}