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

        public static void generateInfoForCorpAdmin(string s)
        {

        if (File.Exists(@"resultFiles\CorporateAdmin.txt") == false){
            StreamWriter writer = new StreamWriter(@"resultFiles\CorporateAdmin.txt");
                for(int i = 0 ; i < SectA.readHRMasterList().Count ; i++){
                    writer.WriteLine(SectA.readHRMasterList()[i].CAD());  
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
                for(int i = 0 ; i < SectA.readHRMasterList().Count ; i++){
                    writer.WriteLine(SectA.readHRMasterList()[i].PD());  
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
                for(int i = 0 ; i < SectA.readHRMasterList().Count ; i++){
                    writer.WriteLine(SectA.readHRMasterList()[i].ITD());  
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
