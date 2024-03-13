using System;
using System.ComponentModel.DataAnnotations;

namespace SkillSphere.Model.Db
{
	public class Skill
	{
		public int Id { get; set; }

		[Required]
		[MinLength(2)]
        [MaxLength(30)]
        public string Title { get; set; }
	}
}

