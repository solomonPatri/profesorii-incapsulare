﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Profesorii.Liceu.model;

namespace Profesorii.Profesori.model
{
    public class Profesor
    {
        private int _id;
        private string _nume;
        private int _studenti;
        private int _orelucrate;
        private LiceuCategory _specialitate;


        public int Id
        {
            get { return _id;}
            set { _id = value; }

        }
        public string Nume
        {
            get { return _nume; }
            set { _nume = value; }
        }
      
         public int Studenti
        {
            get { return _studenti; }
            set { _studenti = value; }

        }
        public int Orelucrate
        {
            get { return _orelucrate;}
            set { _orelucrate = value;}
        }
        public LiceuCategory Specialitate
        {
            get { return _specialitate; }
            set { _specialitate = value; }
        }

        public string DescriereProfesor()
        {
            string desc = " ";
            desc += "Nume: " + this._nume + "\n";
            desc += "clasa: " + this._studenti + "\n";
            desc += "Ore lucru: " + this._orelucrate + "\n";
            desc += "Specialitate: " + this._specialitate + "\n";

            return desc;
        }

        public Profesor (int id,string nume,int orelucrate,int studenti,LiceuCategory materie)
        {
            _id = id;
            _nume = nume;
            _specialitate = materie;
            _studenti = studenti;  
            _orelucrate= orelucrate;
            

        }











    }
}
