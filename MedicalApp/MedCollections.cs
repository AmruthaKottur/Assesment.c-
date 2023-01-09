using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFrameworks.MedicalApp
{
    interface IDataComponent
    {
        void AddDisease(Diseases dis);
        void AddSymptoms(Symptoms sym);

       
    }
    class MedCollections : IDataComponent
    {
        private ArrayList _listOfDiseases = new ArrayList();
        public void AddDisease(Diseases dis)
        {
            _listOfDiseases.Add(dis);
            //throw new NotImplementedException();
        }

        public void AddSymptoms(Symptoms sym)
        {
            throw new NotImplementedException();
        }
    }
}
