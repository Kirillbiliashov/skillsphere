using System;
namespace SkillSphere.Model.Db
{
	public class Client
	{
        public int Id { get; set; }

        public double Paid { get; set; }

        public int UserId { get; set; }

        public List<Job> Jobs { get; set; }

        public List<Chat> Chats { get; set; }

        public List<Rating> Ratings { get; set; }

        public User User { get; set; }

    }
}

