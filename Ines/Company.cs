using System;
using System.Collections.Generic;
using System.Text;

namespace Ines
{

    //Clase

    public class Company
    {
        public string _name;
        public double _saveproject;

        public string Name { get { return _name; } }
        public double SaveProject { get { return _saveproject; } }

        public Company(string name, double saveproject)
        { _name = name; _saveproject = saveproject; }

        public void Save(double save)
        { _saveproject += save; }

        public void Spend(double save) { _saveproject += save; }
        public void ChangeName(string name) { _name = name; }
    }
}





