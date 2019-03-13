using System.Data.Entity;

namespace ProjectRider.Models
{
    public class ProjectRiderDbContext : DbContext
    {
        public virtual IDbSet<Project> Projects { get; set; }

        public ProjectRiderDbContext() : base("ProjectRider")
        {
        }
    }
}