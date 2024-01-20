using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Profesorii.Liceul.model
{
    public  class Liceul
    {
        private int _id;
        private int _idProfesor;
        private string _user;
        private string _password;
        private string _liceul;
        private int _nrprofesor=1;
        private string departament;
       private LiceuCategory _specialitate;
       
        
        private int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private int IdPof
        {
            get { return _idProfesor; }
            set { _idProfesor = value; }
         
        }

         private string User {
            get { return _user; }
            set { _user = value; }
        }

        private string Password
        {
            get { return _password; }
            set { _password = value; }

        }

        private string Liceu
        {
            get { return _liceul; }
            set { _liceul = value; }
        }

        private int NrProfesor
        {
            get { return _nrprofesor;}
            set { _nrprofesor = value;}
        }
        public LiceuCategory Specialitate
        {
            get { return _specialitate; }
            set { _specialitate = value; }
        }

        public string DescriereLiceu()
        {
            string desc = " ";
            desc += "User: " + this._user + "\n";
            desc += "Parola: " + this._password + "\n";
            desc += "Liceul: " + this._liceul + "\n";
            desc += "Numarul de profesori: " + this._nrprofesor + "\n";
            desc += "Specialitate: " + this._specialitate + "\n;";
           return desc;
        }

        public Liceul(int id, int idProfesor, string user, string parola, string liceu, int nrprofesori,LiceuCategory specialitate)
        {
            _id = id;
            _idProfesor = idProfesor;
            _user = user;
            _password = parola;
            _liceul = liceu;
            _nrprofesor = nrprofesori;
            _specialitate=specialitate;

        }










    }
}
