using System;
namespace SkillSphere.Model.Db
{
	public class Chat
	{
		public int FreelancerId { get; set; }

        public int ClientId { get; set; }

		public int JobId { get; set; }

		public DateTime CreatedAt { get; set; }

		public List<Message> Messages { get; set; }
    }
}

