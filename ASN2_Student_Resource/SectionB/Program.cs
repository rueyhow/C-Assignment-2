using System;
using System.Collections.Generic;
using System.Linq;
using SectionA;
using System.Threading.Tasks;

namespace SectionB
{
    class Program
    {
        static void Main(string[] args)
        {
            var function1 = GenerateFinalFile(SectionA.SectA.readHRMasterList());


            function1.Wait();
            Console.WriteLine("Success");
        }

        static async Task<List<SectionA.Employee>> GenerateFinalFile(List<SectionA.Employee> datafile)
        {
            var generatePayoutFile = await Task.Run(() => Hire.updateMonthlyPayoutToMasterList(datafile));

            return generatePayoutFile;
        }

    }
}
