using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pg431ExcuseManager
{
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }


        // overloaded triple constructors
        // one for when the form is loaded
        public Excuse()
        {
            
        }

        // one for opening a file
        public Excuse(string fileToOpen)
        {
            ExcusePath = fileToOpen;    
        }

        // and one for a random excuse
        public Excuse(int rand)
        {

        }


        // run the save and open logic based on calls from the form, somehow?
        public void OpenFile(string fileToOpen)
        {

        }

        public void Save(string fileToSave)
        {
            
        }
    }

}