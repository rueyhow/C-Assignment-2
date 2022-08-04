using System;
using System.Text;
using RGiesecke.DllExport;

namespace SectionA{
    public class Employee{

        public string NRIC {get;set;}

        public string Fullname {get;set;}

        public string Salutation {get;set;}

        public DateTime StartDate {get;set;}

        public string Designation {get;set;}

        public string Department {get;set;}

        public string MobileNo {get;set;}

        public string HireType {get;set;}

        public double salary {get;set;}

        public double MonthlyPayout  {get;set;}

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
            return $"NRIC : {NRIC} , Full Name : {Fullname} , Start Date : {StartDate.ToString("dd/MM/yyyy")} , Department : {Department} , Mobile Number : {MobileNo}";
        }

        public string All(){
        return $"{NRIC}|{Fullname}|{Salutation}|{StartDate.ToString("dd/MM/yyyy")}|{Designation}|{Department}|{MobileNo}|{HireType}|{salary}|{MonthlyPayout}";
        }

    }
}