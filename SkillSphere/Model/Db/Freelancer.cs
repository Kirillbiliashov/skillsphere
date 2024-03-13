using System;
namespace SkillSphere.Model.Db
{
	public class Freelancer: User
	{
		public double Earned { get; set; }

		public List<FreelancerJob> Jobs { get; set; }
    }
}

