using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;


namespace SectionA
{
    
    class info
    {
        public static List<Employee> GetData(){
            List<Employee> listOfData = new List<Employee>(){};
            foreach(string employee in Program.readHRMasterList())
            {
            
            string[] data = employee.Split("|");

            listOfData.Add(new Employee(data[0] ,data[1] , data[2] , Convert.ToDateTime(data[3]) , data[4] , data[5] , data[6] , data[7] , Convert.ToDouble(data[8])));
        };

        return listOfData;
        }


        public static void generateInfoForCorpAdmin(string s)
        {

        if (File.Exists(@"resultFiles\CorporateAdmin.txt") == false){
            StreamWriter writer = new StreamWriter(@"resultFiles\CorporateAdmin.txt");
                for(int i = 0 ; i < GetData().Count ; i++){
                    writer.WriteLine(GetData()[i].CAD());  
                }
            writer.Close();
        }
        else
        {
            Console.WriteLine("File Already Exists");
        }
        }

        public static void generateInfoForProcurement(string s){


        if (File.Exists(@"resultFiles\Procurement.txt") == false){
            StreamWriter writer = new StreamWriter(@"resultFiles\Procurement.txt");
                for(int i = 0 ; i < GetData().Count ; i++){
                    writer.WriteLine(GetData()[i].PD());  
                }
            writer.Close();
        }
        else
        {
            Console.WriteLine("File Already Exists");
        }
        }

        public static void generateInfoForITDepartment(string s){


            if (File.Exists(@"resultFiles\ITDepartment.txt") == false){
            StreamWriter writer = new StreamWriter(@"resultFiles\ITDepartment.txt");
                for(int i = 0 ; i < GetData().Count ; i++){
                    writer.WriteLine(GetData()[i].ITD());  
                }
            writer.Close();
            
        }
        else
        {
            Console.WriteLine("File Already Exists");
        }
        }

    }
}
