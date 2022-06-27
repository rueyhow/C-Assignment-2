using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SectionA
{
    public class SectA
    {
        public delegate void DelegateAll(string msg);

        public static List<Employee> readHRMasterList()
        {
            List<string> allLinesText = System.IO.File.ReadAllLines(@"D:\sch stuff\y2\AVP\assignment2\C-Assignment-2\ASN2_Student_Resource\HRMasterlist.txt").ToList();

            List<Employee> listOfData = new List<Employee>(){};
            foreach(string employee in allLinesText)
            {
            
            string[] data = employee.Split("|");


            listOfData.Add(new SectionA.Employee(data[0] ,data[1] , data[2] , Convert.ToDateTime(data[3]).Date , data[4] , data[5] , data[6] , data[7] , Convert.ToDouble(data[8])));
        };

        return listOfData;
        }

        static void Main(string[] args)
        {
            DelegateAll del1 = info.generateInfoForCorpAdmin;
            DelegateAll del2 = info.generateInfoForITDepartment;
            DelegateAll del3 = info.generateInfoForProcurement;
            DelegateAll all = del1 + del2 + del3;
            all("Success");
        }
    }
}
