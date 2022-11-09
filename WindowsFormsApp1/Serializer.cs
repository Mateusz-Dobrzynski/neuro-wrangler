using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    /// <summary>
    /// This class makes use of JSON.NET framework to serialize objects into JSON files and revert this operation.
    /// </summary>
    public class Serializer
    {
        /// <summary>
        /// This method allows to save objects as JSON files
        /// </summary>
        /// <param name="objectToSave">Object to be saved</param>
        /// <param name="path">Directory in which object will be saved</param>
        public void Save(INeuroObject objectToSave, string path)
        {
            string fileContent = JsonConvert.SerializeObject(objectToSave);
            File.WriteAllText($"{path}/{objectToSave.name}.json", fileContent);
        }

        /// <summary>
        /// Allows to load JSON file and deserialize it
        /// </summary>
        /// <param name="path"></param>
        public void Load(string path)
        {
            throw new NotImplementedException();
            FileStream fs = File.OpenRead(path);
            byte[] bytes = Encoding.UTF8.GetBytes(path);
            List<string> lines = new List<string>();
            UTF8Encoding temp = new UTF8Encoding(true);
            int readLenght;
            while ((readLenght = fs.Read(bytes, 0, bytes.Length)) > 0) {
                lines.Add(temp.GetString(bytes, 0, bytes.Length));
            }
        }
    }
}