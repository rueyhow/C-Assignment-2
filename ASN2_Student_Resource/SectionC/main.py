print(sum(map(lambda employee: float(employee[-1]) * 0.85 if employee[7] == 'FullTime' and int(employee[3].split('/')[-1]) > 95 else 0,[employee.split('|') for employee in open("ASN2_Student_Resource\SectionB\HRMasterlistB.txt").read().split('\n')])))









