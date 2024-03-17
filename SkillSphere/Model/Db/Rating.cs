using System;
using System.ComponentModel.DataAnnotations;

namespace SkillSphere.Model.Db
{
	public class Rating
	{
		public int JobId { get; set; }

		public int FreelancerId { get; set; }

		public int ClientId { get; set; }

		public double Value { get; set; }

        public string? Description { get; set; }

        [Required]
		public bool IsFreelancerRated { get; set; }

		public Freelancer Freelancer { get; set; }

        public Job Job { get; set; }

        public Client Client { get; set; }


    }
}

