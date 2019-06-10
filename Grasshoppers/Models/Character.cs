using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models
{
    /// <summary>
    /// Represents a character of some user in database
    /// </summary>
    public class Character
    { 
        /// <summary>
        /// Serialized info about sprite of this character
        /// </summary>
        [Required]
        internal string Sprite { get; private set; }
        
        /// <summary>
        /// Serialized info about a position of this character (map, coords, etc.)
        /// </summary>
        [Required]
        internal string Position { get; private set; }
        
        public int Id { get; set; }
        
        [Required, MaxLength(50), MinLength(2)]
        public string Name { get; set; }
        
        [Required]
        public PlayerGender Gender { get; set; }
        
        /// <summary>
        /// Last time when user quit this character
        /// </summary>
        [Required]
        public DateTime LastTimeOnline { get; set; }

        public ICollection<InventoryEntry> Inventory { get; set; }
        
        /// <summary>
        /// List of results of character in different game sessions
        /// </summary>
        public ICollection<CharacterResultEntry> Results { get; set; }

        public Character()
        {
            Inventory = new List<InventoryEntry>();
            Results = new List<CharacterResultEntry>();
        }
    }
}