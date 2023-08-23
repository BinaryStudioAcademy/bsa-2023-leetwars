using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.DAL.Entities
{
    public class Sample : AuditEntity<long>
    {
        public string Title { get; set; } = string.Empty;
        public string? Body { get; set; }
    }   
}
