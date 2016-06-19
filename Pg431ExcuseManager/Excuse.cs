using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Pg431ExcuseManager
{
    [Serializable]
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
            string[] fileNames = Directory.GetFiles(folderPath, "*.excuse");
            if (fileNames.Length > 0)
            {
                ExcusePath = fileNames[rand.Next(fileNames.Length)];
                OpenFile(ExcusePath);
            }
        }
        
        public void OpenFile(string fileToOpen)
        {
            using (Stream input = File.OpenRead(fileToOpen))
            {
                if (input.Length > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    Excuse readExcuse = (Excuse)formatter.Deserialize(input);
                    Description = readExcuse.Description;
                    Results = readExcuse.Results;
                    LastUsed = readExcuse.LastUsed;
                    ExcusePath = readExcuse.ExcusePath;
                }
            }
        }

        public void Save(string fileToSave)
        {
            using (Stream output = File.Create(fileToSave))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, this);
            }
        }
    }
}