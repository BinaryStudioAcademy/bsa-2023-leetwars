using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.BLL.Exceptions
{
    public sealed class NotFoundException : Exception
    {
        public NotFoundException(string name, long id)
            : base($"Entity {name} with id ({id}) was not found.") { }
        
        public NotFoundException(string name, string id)
            : base($"Entity {name} with id ({id}) was not found.") { }

        public NotFoundException(string name) : base($"Entity {name} was not found.") { }
    }
}
