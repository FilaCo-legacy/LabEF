using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Grasshoppers.Models
{
    public class CharacterConfiguration : IEntityTypeConfiguration <Character>
    {
        public void Configure(EntityTypeBuilder<Character> builder)
        {
            builder.HasAlternateKey(curPlayer => curPlayer.Name);
            
            builder
                .Property(player => player.Gender)
                .HasConversion(property => property.ToString(),
                    property => (CharacterGender) Enum.Parse(typeof(CharacterGender), property));
        }
    }
}