using System;
namespace SkillSphere.Model.Db
{
	public class Freelancer
	{
		public int Id { get; set; }

		public double Earned { get; set; }

		public int UserId { get; set; }

		public List<FreelancerJob> Jobs { get; set; }

        public List<Chat> Chats { get; set; }

        public List<Rating> Ratings { get; set; }

		public User User { get; set; }
    }
}

