using System.Collections.Generic;

namespace PatientTracker.Models
{
  public class Doctor
  {
    public Doctor()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();

      // this.JoinEntities2 = new HashSet<DoctorSpecialty>();

    }

    public int DoctorId { get; set; }

    public string Name { get; set; }

    public string Specialty { get; set; }

    public virtual ICollection<DoctorPatient> JoinEntities { get; set; }
  }
}
