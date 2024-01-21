using Profesorii.Liceu.model;
using Profesorii.Liceu.Service;
using Profesorii.Profesori.service;
using Profesorii.Profesori.model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesorii
{
    public class View
    {
        private ServiceProfesor _serviceprofesor;
        private ServiceLiceul _serviceliceu;


        public View()
        {
            _serviceliceu = new ServiceLiceul();
            _serviceprofesor = new ServiceProfesor();
            play();
        }

        public void meniu()
        {
            Console.WriteLine("1-> Afisarea Liceelor: ");
            Console.WriteLine("2->Afisarea profesoriilor: ");
            Console.WriteLine("3->Cautati liceul de specialitate: ");
            Console.WriteLine("4->Introduceti adaugarea de Liceu: ");
            Console.WriteLine("5->Total de studenti a Profesoriilor este: ");
            Console.WriteLine("6->Media orelorlucrate de profesori:");
            Console.WriteLine("7->Afisarea Profesoiilor in functie de Licee: ");

        }
         public void play()
        {
            bool run = true;

            while (run)
            {
                meniu();
                int alegere = int.Parse(Console.ReadLine());
                switch (alegere)
                {
                    case 1: _serviceliceu.afisare();
                        break;
                    case 2:
                        _serviceprofesor.afisare();
                        break;
                        case 3:
                        returnliceuSpecialitate();
                        break;
                    case 4:
                        adaugareLiceu();
                        break;
                    case 5:
                        afisarestudentiProfesorilor();
                        break;
                    case 6:
                        afisaremediaoreLucrate();
                        break;
                    case 7:
                        afisareLiceuByProfesor();
                        break;
                   

                }

            }

         }
        public List<Liceul> returnliceuSpecialitate()
        {
            Console.WriteLine("Introduceti Categoria: ");
            LiceuCategory specializare = (LiceuCategory)Enum.Parse(typeof(LiceuCategory), specializare.ToString());

            List<Liceul> liceulales =  _serviceLiceu.Returnareliceu(specializare);

            return liceulales;

        }

        public void adaugareLiceu()
        {
            Console.WriteLine("Introduceti specialitatea:");

            int i = 1;
            foreach(var Specializare in Enum.GetValues(typeof(LiceuCategory)))
            {
                Console.WriteLine(i + "->" + Specializare);
                i++;
            }
            string Specializare= Console.ReadLine();
            LiceuCategory specializare = (LiceuCategory)Enum.Parse(typeof(LiceuCategory), Specializare.ToString());
            List<Liceul> liceulcautat = _serviceliceu.FiltrareCategorie(specializare);
            Console.WriteLine("Liceul cu specializare" + specializare + " adaugata:" + "\n");
            foreach(Liceul newliceu in liceulcautat)
            {
                Console.WriteLine(newliceu.DescriereLiceu());
            }

        }
     

        public void afisarestudentiProfesorilor()
        {
            Console.WriteLine("Studentii a profesorilor este: ");
            _serviceprofesor.totalstudentiProf();
        }

        public void afisaremediaoreLucrate()
        {
            Console.WriteLine("Media orelor lucrate sunt: ");
            _serviceprofesor.mediaorelorlucrate();
        }


        public void afisareLiceuByProfesor()
        {
            int i = 1;
            foreach (var SpecializareLiceu in Enum.GetValues(typeof(LiceuCategory)))
            {
                Console.WriteLine(i + "->" + SpecializareLiceu);
                i++;
            }
            Console.WriteLine("Introduceti specializarea profesorului respectiv: ");
            LiceuCategory specializare = (LiceuCategory)Enum.Parse(typeof(LiceuCategory), SpecializareLiceu.ToString());
            Console.WriteLine("Liceele cu specializarea astea sunt:");
            Console.WriteLine( _serviceliceu.Organizareprofesor(specializare));


        }
       



    }
}
