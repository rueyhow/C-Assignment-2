from datetime import datetime
class Employee:
    def __init__(self , NRIC : str, Fullname : str, Salutation : str , StartDate : datetime , Designation  : str , Department : str , MobileNo : str , HireType : str , salary : int) -> None:
        self.NRIC = NRIC

        self.Fullname = Fullname
            
        self.Salutation = Salutation

        self.StartDate = StartDate

        self.Designation = Designation

        self.Department = Department

        self.MobileNo = MobileNo

        self.HireType = HireType

        self.salary = salary

        self.MonthlyPayout = 0.0