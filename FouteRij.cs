using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht4
{
    internal class FouteRij<T>
    {
        private List<T> rij = new List<T>();
        private List<T> rij2 = new List<T>();
        private T val;


        public T inDeRij(T element)
        {
            rij.Add(element);
            if (rij.Count == 1)
            {
                val = element;
            }
            return val;
        }

        public T Delete()
        {
            rij.Remove(val);
            if (rij.Count > 0)
            {
                val = rij[0];
            }
            return val;
        }

        public T Next()
        {
            if (rij.Count < 0)
            {
                int rowNumber = rij.IndexOf(val);
                if (rowNumber == rij.Count - 1)
                {
                    return rij[0];
                }
                else
                {
                    return rij[rowNumber + 1];
                }
            }
            return val;
        }

        public bool isEmpty()
        {
            if (rij.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int Count()
        {
            return rij.Count;
        }

        public T ZetAchteraan()
        {
            if (rij.Count <= 0)
            {
                rij.Remove(val);
                rij.Add(val);
                val = rij[0];
            }
            return val;

        }

        public void LeegMaken()
        {
            rij.Clear();
        }

        public override string ToString()
        {
            string showList = "";

            foreach (T ele in rij)
            {
                showList += ele.ToString();
            }

            return showList;
        }

        public List<T> rijCopy()
        {
            rij2 = rij.GetRange(0, rij.Count);

            return rij2;
        }
    }
}
