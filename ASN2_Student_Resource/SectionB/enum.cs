using System;
using System.Collections.Generic;
using System.Linq;
using SectionA;
using static SectionA.Employee;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
namespace SectionB
{
    public enum HireTypes
    {
        FullTime = 1,
        PartTime = 2,
        Hourly = 4
    }
    class Hire
    {
    public static List<SectionA.Employee> processPayroll(List<SectionA.Employee> HRMasterlist){
        string stars = String.Concat(Enumerable.Repeat("*", 29));
        double totalPayout = 0;
        Dictionary<string, int> HiringTypes = Enum.GetValues(typeof(HireTypes))
                                .Cast<HireTypes>()
                                .ToDictionary(k => k.ToString(), v => (int)v);
        for(int i = 0 ; i < HRMasterlist.Count ; i++)
        {
            foreach(var value in HiringTypes)
            {
                if (HRMasterlist[i].HireType == value.Key)
                {
                    HRMasterlist[i].MonthlyPayout = HRMasterlist[i].salary / value.Value;
                    totalPayout +=  HRMasterlist[i].MonthlyPayout;

                    Console.WriteLine($"{HRMasterlist[i].Fullname} ({HRMasterlist[i].NRIC})");
                    Console.WriteLine($"{HRMasterlist[i].Designation}");
                    Console.WriteLine($"Monthly Payout : {HRMasterlist[i].MonthlyPayout}");
                    Console.WriteLine(stars);
                }
            }
        }
        Console.WriteLine($"Total Payroll Amount : ${totalPayout} to be paid to employees");
        return HRMasterlist;
    }
    

    public static List<SectionA.Employee> updateMonthlyPayoutToMasterList(List<SectionA.Employee> datafile){

        List<SectionA.Employee> HRMasterlist = processPayroll(datafile);
         if (File.Exists(@"HRMasterlistB.txt") == false){
            StreamWriter writer = new StreamWriter(@"HRMasterlistB.txt");
                for(int i = 0 ; i < HRMasterlist.Count ; i++){
                    writer.WriteLine(HRMasterlist[i].All());  
                }
            writer.Close();
            return datafile;
        }
        else
        {
            Console.WriteLine("File Already Exists");
            return datafile;
        }
    }


    }
}
