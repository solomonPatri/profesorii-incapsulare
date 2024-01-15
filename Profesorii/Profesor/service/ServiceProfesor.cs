using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Profesorii.Liceul.model;
using Profesorii.Profesor.model;

namespace Profesorii.Profesor.service
{

    public class ServiceProfesor
    {
        private List<Profesor> _serviceprofesor;


        public ServiceProfesor()
        {
            _serviceprofesor = new List<Profesor>();
            this.load();

        }

        private void load()
        {
            Profesor p1 = new Profesor(1, "Mihai", 243, 8, "Matematica");
            Profesor p2 = new Profesor(2, "Andrea", 4532, 6, "Romana");
            Profesor p3 = new Profesor(3, "Mario", 2754, 9, "Engleza ");
            Profesor p4 = new Profesor(4, "Adrian ", 522, 4, "Istorie");

            _serviceprofesor.Add(p1);
            _serviceprofesor.Add(p2);
            _serviceprofesor.Add(p3);
            _serviceprofesor.Add(p4);
        }

        public void afisare()
        {
            for (int i = 0; i < _serviceprofesor.Count; i++)
            {
                Console.WriteLine(_serviceprofesor[i].DescriereProfesor());

            }

        }

        public void sortarealfabetic()
        {
            for (int i = 0; i < _serviceprofesor.Count - 1; i++)
            {
                for (int j = i + 1; j < _serviceprofesor.Count; j++)
                {
                    if (_serviceprofesor[i].Nume > _serviceprofesor[j].Nume)
                    {
                        Profesor aux = _serviceprofesor[i];
                        _serviceprofesor[i] = _serviceprofesor[j];
                        _serviceprofesor[j] = aux;


                    }

                }


            }
        }
        public void afisarelista()
        {
            Console.WriteLine("Lista de profesor in functie de nume sunt : ");
            sortarealfabetic();
            for (int i = 0; i < _serviceprofesor.Count; i++)
            {
                Console.WriteLine(_serviceprofesor[i] + "\n");


            }
        }

        public int totalstudentiProf()
        {
            int suma = 0;

            for (int i = 0; i < _serviceprofesor.Count; i++)
            {
                suma += _serviceprofesor[i].studenti;
            }
            return suma;
        }
        public int mediarelorlucrate()
        {
            int suma = 0;
            for(int i=0;i< _serviceprofesor.Count; i++)
            {

                suma += _serviceprofesor[i].Orelucrate;
            }

            return suma / _serviceprofesor.Count;
        }

        
    }


}
