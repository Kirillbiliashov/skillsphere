using System;
using System.ComponentModel.DataAnnotations;

namespace SkillSphere.Model.Db
{
	public class FreelancerJob
	{
		public int JobId { get; set; }

		public int FreelancerId { get; set; }

		[Required]
		public JobStatus Status { get; set; }

		public Job Job { get; set; }

		public Freelancer Freelancer { get; set; }

	}

	public enum JobStatus
	{
		Applied,
		InProgress,
		Complete
	}
}

