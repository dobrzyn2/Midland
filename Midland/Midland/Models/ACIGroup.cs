using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Midland.Models
{
    public class ACIGroup
    {
        private List<ACIInstance> instances;

        public ACIGroup()
        {
            this.instances = new List<ACIInstance>();
        }

        public bool CanAddInstance()
        {
            // TODO: Connect to azure cloud to determine if this group can add an instance
            return true;
        }

        public bool AddInstance()
        {
            // TODO: Connect to azure cloud and create an instance
            this.instances.Add(new ACIInstance());
            return true;
        }
    }
}
