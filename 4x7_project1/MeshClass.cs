using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1_4x7
{
    class MeshClass
    {
        //properties
        public int ID;
        public double numberOfElements;
        public List<int> listOfElementID;

        //constructor
        public MeshClass()
        {
        //moze byc pusty (konstruktor class po new)

        }
        public MeshClass(int _ID)
        {
            ID = _ID;
        }
    }
}
