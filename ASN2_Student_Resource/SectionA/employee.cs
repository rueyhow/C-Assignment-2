using System;
using System.Text;

namespace SectionA{


    public class Employee{

        string NRIC {get;set;}

        string Fullname {get;set;}

        string Salutation {get;set;}

        DateTime StartDate {get;set;}

        string Designation {get;set;}

        string Department {get;set;}

        string MobileNo {get;set;}

        string HireType {get;set;}

        double salary {get;set;}

        double MonthlyPayout  {get;set;}

        public Employee(string NRIC , string Fullname , string Salutation , DateTime StartDate , string Designation ,string Department ,  string MobileNo , string HireType , double salary){
            this.NRIC = NRIC;

            this.Fullname = Fullname;
            
            this.Salutation = Salutation;

            this.StartDate = StartDate;

            this.Designation = Designation;

            this.Department = Department;

            this.MobileNo = MobileNo;

            this.HireType = HireType;

            this.salary = salary;

            this.MonthlyPayout = 0.0;
        }

        public string  CAD(){
            return $"Full Name : {Fullname} , Designation : {Designation} , Department : {Department}";
        }
        public string PD(){
            return $"Salutation : {Salutation} , Full Name : {Fullname} , Mobile Number : {MobileNo} , Designation : {Designation} , Department : {Department}";
        }

        public string ITD(){
            return $"NRIC : {NRIC} , Full Name : {Fullname} , Start Date : {StartDate} , Department : {Department} , Mobile Number : {MobileNo}";
        }

    }
}