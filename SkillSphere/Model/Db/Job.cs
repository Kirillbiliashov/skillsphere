using System;
using System.ComponentModel.DataAnnotations;

namespace SkillSphere.Model.Db
{
	public class Job
	{
		public int Id { get; set; }

		[Required]
		[MinLength(6)]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MinLength(6)]
        public string Description { get; set; }

        public string Location { get; set; }

        public int Duration { get; set; }

        public int ClientId { get; set; }

        public Client Client { get; set; }

        public List<Skill> Skills { get; set; }
    }
}

