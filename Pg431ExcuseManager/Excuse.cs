using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
        public Excuse(string folderPath, Random rand)
        {
            string[] fileNames = Directory.GetFiles(folderPath, "*.txt");
            ExcusePath = fileNames[rand.Next(fileNames.Length)];
            OpenFile(ExcusePath);
        }
        
        public void OpenFile(string fileToOpen)
        {
            using (StreamReader sr = new StreamReader(fileToOpen))
            {
                Description = sr.ReadLine();
                Results = sr.ReadLine();
                LastUsed = Convert.ToDateTime(sr.ReadLine());
            }
        }

        public void Save(string fileToSave)
        {
            using (StreamWriter sw = new StreamWriter(fileToSave))
            {
                sw.WriteLine(Description);
                sw.WriteLine(Results);
                sw.WriteLine(LastUsed.ToString());
            }
        }
    }
}