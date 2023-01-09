using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworks.MedicalApp
{
    class Diseases
    {
        public string DiseaseName { get; set; }
        public string severity { get; set; }
        public string cause { get; set; }
        public string description { get; set; }
    }
    class Symptoms : Diseases
    {
        public string DiseaseName { get; set; }
        public string SymptomName { get; set; }
        public string description { get; set; }
    }
    class PatientDetails : Symptoms
    {
        public string PatientName { get; set; }
        public string SymptomName { get; set; }
    }
}
