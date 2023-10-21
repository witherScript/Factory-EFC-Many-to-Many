using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
    public class Engineer
    {
        public int EngineerId {get; set;}
        [Required(ErrorMessage ="The name field can not be empty!")]
        public string Name {get; set;}
        public List<MachineEngineer> JoinEntities {get; set;}
    }

}