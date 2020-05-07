using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_en_clase
{
    [Serializable]
    class Persona
    {
        private string Name;
        private string LastName;
        private int Age;


        public Persona(string Name, string LastName, int Age)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Age = Age;
        }

    }
}
