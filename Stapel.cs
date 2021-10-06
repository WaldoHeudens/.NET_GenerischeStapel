using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerischeStapel
{
    internal class Stapel<T>
    {
        List<T> stapel = new List<T>();

        public void OpStapel(T toeTeVoegen)
        {
            stapel.Add(toeTeVoegen);
        }

        public T VanStapel()
        {
            if (stapel.Count <= 0)
            {
                throw new Exception();
            }
            T even = stapel[stapel.Count-1];
            stapel.RemoveAt(stapel.Count - 1);
            return even;
        }

 
        public override string ToString()
        {
            string content = "";
            foreach (T t in stapel)
                content += t.ToString() + "; ";
            return content;
        }
    }
}
