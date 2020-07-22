using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DBTest
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; } // Mandatory for databases. The Index/Key field in your Database
        public DateTime Timestamp { get; set; } = DateTime.Now; // Automaticly created a timestamp when adding a new record to the database.
    }

    public class QuestModel : EntityBase
    {
        [MaxLength(50)] // Database Annotations
        [Required]
        public string Name { get; set; } = "Name Missing";
        
        [MaxLength(1000)]
        public string Description { get; set; } = "No Description";
        public List<RewardModel> Rewards { get; set; } = new List<RewardModel>();
    }

    public class RewardModel : EntityBase
    {
        public string Name { get; set; } = "Name Missing";
    }
}
