using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.DAL.Entities.HelperEntities
{
    public static class EntitySettings
    {
        public static readonly int MaxUserNameLength = 15;
        public static readonly int MaxShortNameLength = 15;
        public static readonly int MaxTagNameLength = 25;
        public static readonly int MaxGeneralNameLength = 50;
        public static readonly int MaxDescriptionLength = 100;
        public static readonly int MaxEmailLength = 254;
        public static readonly int MaxPathLength = 260;
        public static readonly int DecimalPartLength = 2;
    }
}
