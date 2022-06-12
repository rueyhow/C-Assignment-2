using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SectionA
{
    class Program
    {
        public delegate void DelegateAll(string msg);
        public static List<string> readHRMasterList()
        {
            List<string> allLinesText = System.IO.File.ReadAllLines(@"D:\Advanced Prog\Assignment 2\C-Assignment-2\ASN2_Student_Resource\HRMasterlist.txt").ToList();
            return allLinesText;
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
