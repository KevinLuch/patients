using Microsoft.EntityFrameworkCore;
using PatientWeb.Models;

namespace PatientWeb.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
    }
}
