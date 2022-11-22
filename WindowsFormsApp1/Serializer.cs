using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

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
        /// <param name="directory">Directory in which object will be saved</param>
        public void Save(INeuroObject objectToSave, string directory)
        {
            string fileContent = JsonConvert.SerializeObject(objectToSave);
            File.WriteAllText($"{directory}/{objectToSave.name}.json", fileContent);
        }

        /// <summary>
        /// Allows to load JSON file and deserialize it
        /// </summary>
        /// <param name="path">Full path of a file to be loaded</param>
        public T Load<T>(string path)
        {
            T deserializedObject = JsonConvert.DeserializeObject<T>(File.ReadAllText(path));
            return deserializedObject;
        }
    }
}