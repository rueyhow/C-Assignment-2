import imp
from msilib import datasizemask
from Employee import Employee
from datetime import datetime
def main():
    datalist = []
    salaryRates = {
        "Full-time" : 1 , 
        "Part-time" : 2,
        "Hourly" : 4
    }
    with open('D:\Advanced Prog\Assignment 2\C-Assignment-2\ASN2_Student_Resource\HRMasterlist.txt') as f:
        lines = f.readlines()
        lines = [line.rstrip() for line in lines]
        for i in range(len(lines)):
            datalist.append(Employee(lines[i].split("|")[0] , lines[i].split("|")[1] , lines[i].split("|")[2] , datetime.strptime(lines[i].split("|")[3] , '%d/%m/%Y').date() , lines[i].split("|")[4] , lines[i].split("|")[5]  ,lines[i].split("|")[6] , lines[i].split("|")[7] , int(lines[i].split("|")[8])))

    
    def Menu():
        for i in range(len(datalist)):
            print("*" * 25)
            print(datalist[i].NRIC)
            print(datalist[i].Fullname)
            print(datalist[i].Salutation)
            print(datalist[i].StartDate)
            print(datalist[i].Designation)
            print(datalist[i].Department)
            print(datalist[i].MobileNo)
            print(datalist[i].HireType)
            print(datalist[i].salary)
            print(datalist[i].MonthlyPayout)
            print(f"Total Salary Payouts : {CalculateSalary()}")
            print("*" * 25)


    def CalculateSalary():

        totalPayout = 0

        baseDate = datetime(1995, 1, 1).date()
        for i in range(len(datalist)):
            if datalist[i].HireType == "FullTime" :
                if datalist[i].StartDate > baseDate :
                    datalist[i].MonthlyPayout = datalist[i].salary * 0.85
                else :
                    datalist[i].MonthlyPayout = datalist[i].salary
            if datalist[i].HireType == "PartTime" :
                datalist[i].MonthlyPayout = datalist[i].salary / 2
            if datalist[i].HireType == "Hourly" :
                datalist[i].MonthlyPayout = datalist[i].salary / 4
            totalPayout += datalist[i].MonthlyPayout
        return totalPayout

    CalculateSalary()
    Menu()

if __name__ == "__main__":
    main()