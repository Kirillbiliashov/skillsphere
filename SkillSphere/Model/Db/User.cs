using System;
using System.ComponentModel.DataAnnotations;

namespace SkillSphere.Model.Db
{
	public abstract class User
	{
		public int Id { get; set; }

		[Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(40)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Location { get; set; }

        public List<Chat> Chats { get; set; }

        public List<Rating> Ratings { get; set; }

    }
}

