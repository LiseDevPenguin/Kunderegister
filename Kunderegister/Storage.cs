using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Kunderegister
{
    class Storage<T>
    {
        private String filename;
        private static IFormatter formatter = new BinaryFormatter();

        public Storage(String filename)
        {
            this.filename = filename;
        }

        public void Save(object obj)
        {
            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            stream.SetLength(0);

            formatter.Serialize(stream, obj);
            stream.Close();
        }

        public T Load()
        {
            Stream stream = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Read);

            T obj;

            try
            {
                obj = (T)formatter.Deserialize(stream);
            }
            catch (SerializationException)
            {
                obj = default(T);
            }
            stream.Close();

            return obj;
        }
    }
}
