using Microsoft.EntityFrameworkCore;

namespace PatientTracker.Models
{
  public class PatientTrackerContext : DbContext
  {
    public DbSet<Doctor> Doctors { get; set; }

    public DbSet<Patient> Patients { get; set; }

    public DbSet<DoctorPatient> DoctorPatient { get; set; }

    public PatientTrackerContext(DbContextOptions options) :
        base(options)
    {
    }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder
    )
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
