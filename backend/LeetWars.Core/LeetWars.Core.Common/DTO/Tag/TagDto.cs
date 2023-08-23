<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.Common.DTO.Tag
{
    public  class TagDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
=======
﻿using LeetWars.Core.DAL.Entities;

namespace LeetWars.Core.Common.DTO.Tag
{
    public class TagDto : Entity<int>
    {
        public string Name { get; set; } = string.Empty;    
>>>>>>> feature/11-implement-entities
    }
}
