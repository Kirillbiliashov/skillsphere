using System;
namespace SkillSphere.Model.Db
{
	public class Message
	{
		public int Id { get; set; }

		public int ChatId { get; set; }

		public int SenderId { get; set; }

		public int ReceiverId { get; set; }

		public string Content { get; set; }

		public DateTime SentAt { get; set; }

		public Chat Chat { get; set; }
    }
}

