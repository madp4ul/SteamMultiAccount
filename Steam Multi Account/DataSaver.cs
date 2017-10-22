using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steam_Multi_Account
{
    class DataSaver<T>
    {
        private T _Data { get; set; }

        private readonly string SavePath;

        public DataSaver(string filename)
        {
            SavePath = Path.Combine(Application.UserAppDataPath, filename + ".json");
        }


        public T Load()
        {
            if (File.Exists(SavePath))
            {
                _Data = JsonConvert.DeserializeObject<T>(File.ReadAllText(SavePath));

            }
            else
            {
                _Data = default(T);
            }
            return _Data;
        }

        public void Save(T storage)
        {
            _Data = storage;
            Save();
        }

        public void Save()
        {
            File.WriteAllText(SavePath, JsonConvert.SerializeObject(_Data));
        }

        public T GetConfiguration()
        {
            return _Data;
        }
    }
}
