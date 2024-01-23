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
using System.Security.Cryptography.X509Certificates;

namespace Profesorii
{
    public class View
    {
        private ServiceProfesor _serviceprofesor;
        private ServiceLiceul _serviceliceu;
        private Profesor _profesor = new Profesor(25, "Mihai-Andrei", 2435, 23, LiceuCategory.Matematica);

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
            Console.WriteLine("8->Doriti sa modificati datele Profesorului?");
            Console.WriteLine("9->Stergeti liceu care depaseste nr de profesor care introduceti:");
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
                    case 1:
                        _serviceliceu.afisare();
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
                    case 8:
                        modificareMaterieProfesor();
                        break;
                    case 9:
                        deleteLiceuByNrProf();
                        break;

                   
                }

            }
        }
            public void returnliceuSpecialitate()
           {
            Console.WriteLine("Introduceti specialitatea pe care doriti sa aflati: ");
            int i = 1;
            
            foreach (var Specialitate in Enum.GetValues(typeof(LiceuCategory)))
            {
                Console.WriteLine(i + "->" + Specialitate);
                i++;
               }
            string Specializare = Console.ReadLine();
            LiceuCategory specializare = (LiceuCategory)Enum.Parse(typeof(LiceuCategory), Specializare.ToString());

            Console.WriteLine(_serviceliceu.Returnareliceu(specializare));

               }

            public void adaugareLiceu()
            {
                Console.WriteLine("Introduceti specialitatea:");

                int i = 1;
                foreach (var speciali in Enum.GetValues(typeof(LiceuCategory)))
                {
                    Console.WriteLine(i + "->" + speciali);
                    i++;
                }
            string Specializare = Console.ReadLine();
            LiceuCategory specializare = (LiceuCategory)Enum.Parse(typeof(LiceuCategory), Specializare.ToString());
            List<Liceul> liceulcautat = _serviceliceu.FiltrareCategorie(specializare);
                Console.WriteLine("Liceul cu specializare" + specializare + " adaugata:" + "\n");
                foreach (Liceul newliceu in liceulcautat)
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
                string Specializare = Console.ReadLine();
                LiceuCategory specializare = (LiceuCategory)Enum.Parse(typeof(LiceuCategory), Specializare.ToString());
                Console.WriteLine("Liceele cu specializarea astea sunt:");
                Console.WriteLine(_serviceliceu.Organizareprofesor(specializare));


            }
           public void modificareMaterieProfesor()
        {
            Console.WriteLine("Introduceti Materia profesorului care doriti sa schimbati:");
            string Materie = Console.ReadLine();
            Console.WriteLine("Introduceti noile date: ");
            Console.WriteLine("Nume: ");
            string Nume = Console.ReadLine();
            Console.WriteLine("Noua Materie: ");
            string nouamaterie = Console.ReadLine();
            LiceuCategory newmaterie = (LiceuCategory)Enum.Parse(typeof(LiceuCategory), nouamaterie.ToString());
            Profesor profesormodif = new Profesor(0, Nume, 0, 0,newmaterie);
            bool response = _serviceprofesor.UpdateProfesor(profesormodif, nouamaterie, Nume, this._profesor.Id);
            if(response == true)
            {
                Console.WriteLine("Datele profesorului au fost modificate cu succes!");
            }
            else
            {
                Console.WriteLine("A aparut o problema!");
               
            }


        }

        public void deleteLiceuByNrProf()
        {
            Console.WriteLine("Introduceti nr de profesor: ");
            int nrprof = int.Parse(Console.ReadLine());
            bool res = _serviceliceu.stergereLiceu(nrprof, this._profesor.Id);
            if(res == true)
            {
                _serviceliceu.afisare();
                Console.WriteLine("A fost sters cu sucess");
            }
            else
            {
                Console.WriteLine("A aparut o problema");
            }



        }

        
    }
}
