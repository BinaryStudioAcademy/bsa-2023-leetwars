﻿using LeetWars.Core.DAL.Entities;
using LeetWars.Core.DAL.Entities.HelperEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeetWars.Core.DAL.Context.EntityConfigurations
{
    public class ChallengeLevelConfig : IEntityTypeConfiguration<ChallengeLevel>
    {
        public void Configure(EntityTypeBuilder<ChallengeLevel> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(EntitySettings.MaxGeneralNameLength);
        }
    }
}
