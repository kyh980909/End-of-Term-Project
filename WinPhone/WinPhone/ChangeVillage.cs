using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WinPhone
{
    class ChangeVillage
    {
        public List<string> village(string country)
        {
            StreamReader file = new StreamReader(country + ".txt");
            List<string> villageList = new List<string>(); 
            string str;
            int i = 0;

            while (true)
            {
                str = file.ReadLine();
                if (str == null)
                    break;

                i++;
                villageList.Add(str);
            }
            file.Close();
            return villageList;
        }
    }
}
