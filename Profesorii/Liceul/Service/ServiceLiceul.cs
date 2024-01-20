using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Profesorii.Liceul.model;
using Profesorii.Profesor.service;

namespace Profesorii.Liceul.Service
{
  public class ServiceLiceul
    {
        private List<Liceul> _serviceliceul;

        public ServiceLiceul()
        {
            _serviceliceul = new List<Liceul>;
            this.load();
        }
        public void load()
        {

            Liceul l1 = new Liceul(20, 1, "matei_20", "3244", "Goga", 36,"Matematica");
            Liceul l2 = new Liceul(21, 2, "butterfly56", "23567", "Eminescu", 45,"Istorie");
            Liceul l3 = new Liceul(22, 3, "Maria34", "23423", "Tehnic Cibinium", 23, "Geografie");
            Liceul l4 = new Liceul(23, 4, "ioan34_5", "43445", "Lazar", 45, "Matematica");


            _serviceliceul.Add(l1);
            _serviceliceul.Add(l2);
            _serviceliceul.Add(l3);

        }
        public void afisare()
        {
            for (int i = 0; i < _serviceliceul.Count; i++)
            {
                Console.WriteLine(_serviceliceul[i]);

            }

        }
        public List <Liceul> FiltrareByProfesorId(int idProf)
        {
            List<Liceul> liceu = new List<Liceul>();

            for(int i = 0; i < _serviceliceul.Count; i++)
            {
                if (_serviceliceul[i].IdProf.Equals(idProf))
                {
                    liceu.Add(liceu[i]);
                }
            }

            return liceu;

        }

        public bool adaugare(Liceul idProf)
        {
            List<Liceul> newliceu = FiltrareByProfesorId(idProf.IdProf);

            for(int i = 0; i < _serviceliceul.Count; i++)
            {
                if (idProf.IdProf.Equals(newliceu[i]))
                {
                    return false;
                }
            }
            _serviceliceul.Add(idProf);
            return true;
        }

        public void returnareliceu(LiceuCategory specialitate)
        {
            List<liceul> liceu = _serviceliceul;
            for(int i = 0; i < _serviceliceul.Count; i++)
            {
                if (_serviceliceul[i].Specialitate == specialitate)
                {
                    return _serviceliceul[i];
                }
                
            }return null;
        }

       public List<Liceul> FiltrareCategorie(LiceuCategory liceulcautat)
        {
            List<Liceul> liceu = new List<Liceul>();
            foreach(var liceul in _serviceliceul)
            {
                if (liceul.Specialitate.Equals(liceulcautat))
                {
                    liceu.Add(liceul);
                }
            }
            return liceu;
        }
        // afisarea nr 7
        public List<Liceul> Organizareprofesor(LiceuCategory specializare) 
        {
            List<Liceul> LiProf = new List<Liceul>();

           
            for(int i=0;i<_serviceliceul.Count;i++)
            {
                if (_serviceliceul[i].Specialitate.Equal(_serviceprofesor.specializare))
                {
                    LiProf = _serviceliceul[i];
                }



            }
            return LiProf.DescriereLiceu();

        }




    }
}
