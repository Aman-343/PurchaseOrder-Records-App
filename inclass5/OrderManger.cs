using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inclass5
{
    class OrderManger
    {
        public void AddNewOrder(Order newUser, string fileName)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(newUser.ToString());
            }
        }

        public void AlreadyOrder(Order newUser, int id, string fileName)
        {

            {
                String UserInfo = newUser.ToString();
                string[] arrLine = File.ReadAllLines(fileName);
                arrLine[id - 1] = UserInfo;
                File.WriteAllLines(fileName, arrLine);
            }

        }
    }
}
