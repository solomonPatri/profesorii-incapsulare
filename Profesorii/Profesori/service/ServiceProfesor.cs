﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Profesorii.Liceu.model;
using Profesorii.Profesori.model;

namespace Profesorii.Profesori.service
{

    public class ServiceProfesor
    {
        List<Profesor> _serviceprofesor;

        public ServiceProfesor()
        {
            _serviceprofesor = new List<Profesor>();
            this.load();

        }

        private void load()
        {
            Profesor p1 = new Profesor(1, "Mihai", 243, 8, LiceuCategory.Matematica);
            Profesor p2 = new Profesor(2, "Andrea", 4532, 6, LiceuCategory.Literatura);
            Profesor p3 = new Profesor(3, "Mario", 2754, 9, LiceuCategory.Fizica);
            Profesor p4 = new Profesor(4, "Adrian ", 522, 4, LiceuCategory.Istorie);

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

        public List<Profesor> FiltrareByProfId(int Idprofesor)
        {
            List<Profesor> profesor = new List<Profesor>();
           
            for(int i =0; i < _serviceprofesor.Count; i++)
            {
                if (_serviceprofesor[i].Id.Equals(Idprofesor))
                {
                    profesor.Add(_serviceprofesor[i]);
                }
            }
            return profesor;

        }


        public void sortarealfabetic()
        {
            for (int i = 0; i < _serviceprofesor.Count - 1; i++)
            {
                for (int j = i + 1; j < _serviceprofesor.Count; j++)
                {
                    if (_serviceprofesor[i].Nume.Equals(_serviceprofesor[j].Nume))
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
                suma += _serviceprofesor[i].Studenti;
            }
            return suma;
        }
        public int mediaorelorlucrate()
        {
        
            int suma = 0;
            for(int i=0;i< _serviceprofesor.Count; i++)
            {
                suma = suma + _serviceprofesor[i].Orelucrate;


            }

            return suma / _serviceprofesor.Count;
        }
        
       public bool UpdateProfesor (Profesor deUpdate,String Materia,String Nume,int _idProfesor)
        {
            List<Profesor> profesor = FiltrareByProfId(_idProfesor);
            for(int i =0; i<profesor.Count;i++)
            {
                if (Materia.Equals(profesor[i]))
                { 
                    if(!deUpdate.Specialitate.Equals(Materia))
                    {
                        profesor[i].Specialitate = deUpdate.Specialitate;
                    }
                    if (!deUpdate.Nume.Equals(Nume))
                    {
                        profesor[i].Nume = deUpdate.Nume;
                    }
                    return true;
 
                   


                }



            }

            return false;

        }

       




    }


}
