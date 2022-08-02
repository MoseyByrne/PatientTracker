using System;
using System.Collections.Generic;

namespace PatientTracker.Models
{
  public class Patient
  {
    public Patient()
    {
      this.JoinEntities = new HashSet<DoctorPatient>();
    }

    public int PatientId { get; set; }

    public string Description { get; set; }

    public DateTime Birthdate { get; set; }

    public virtual ICollection<DoctorPatient> JoinEntities { get; }
  }
}
