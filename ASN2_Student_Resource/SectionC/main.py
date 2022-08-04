from functools import reduce
print(
    sum(
        map(
            lambda employee: float(employee[-1]) * 0.85 if employee[7] == 'FullTime' and int(employee[3].split('/')[-1]) > 1995 else 0,
                [employee.split('|') for employee in open("D:\Advanced Prog\Assignment 2\C-Assignment-2\ASN2_Student_Resource\SectionB\HRMasterlistB.txt").read().split('\n')])))


print(
    sum(
        map(
            lambda employee: float(employee[-1]) * 0.85 if employee[7] == 'FullTime' and int(employee[3].split('/')[-1]) > 1995 else 0,
                list(map(lambda employee : employee.split('|')  , open("D:\Advanced Prog\Assignment 2\C-Assignment-2\ASN2_Student_Resource\SectionB\HRMasterlistB.txt").read().split('\n')))
        )
    )
)



