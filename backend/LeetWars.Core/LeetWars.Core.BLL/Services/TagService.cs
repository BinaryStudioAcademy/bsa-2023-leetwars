﻿using AutoMapper;
using LeetWars.Core.BLL.Interfaces;
using LeetWars.Core.Common.DTO.Tag;
using LeetWars.Core.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetWars.Core.BLL.Services
{
    public class TagService : BaseService, ITagService
    {
        public TagService(LeetWarsCoreContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public async Task<ICollection<TagDto>> GetAllTagsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
