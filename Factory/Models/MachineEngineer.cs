namespace Factory.Models
{
    public class MachineEngineer
    {
     public int MachineEngineerId { get; set; }

     public int MachineId { get; set; }

     public Machine Machine {get; set;}

     public int EngineerId { get; set;}

     public Engineer Engineer {get; set; }
    }

}

