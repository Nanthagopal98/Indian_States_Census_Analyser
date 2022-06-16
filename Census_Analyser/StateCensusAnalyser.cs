using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Globalization;

namespace Census_Analyser
{
    public class StateCensusAnalyser
    {
        public int Analyser(string path)
        {
            try
            {
                int count;
                using (StreamReader reader = new StreamReader(path))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var items = csv.GetRecords<CensusModel>().ToList();
                    count = items.Count();
                    foreach (var item in items)
                    {
                        Console.WriteLine(item.State + "\n" + item.Population + "\n" + item.AreaInSqKm + "\n" + item.DensityPerSqKm);
                        Console.WriteLine("=======================");
                    }
                    Console.WriteLine(count);
                    return count;
                }
            }
            catch (CsvHelper.MissingFieldException)
            {
                Console.WriteLine("Check Delimiter");
                throw new CustomExceptioncs(CustomExceptioncs.ExceptionType.INCORRECT_DELIMITER, "Check Delimiter");
            }
            catch (CsvHelper.HeaderValidationException)
            {
                Console.WriteLine("Check Header");
                throw new CustomExceptioncs(CustomExceptioncs.ExceptionType.INCORRECT_HEADER, "Check Header");
            }
        }
        //For Testcase 1.2 & 1.3
        public void CensusAdapter(string path)
        {
            if (!path.Contains(".csv"))
            {
                Console.WriteLine("Check File type");
                throw new CustomExceptioncs(CustomExceptioncs.ExceptionType.INCORRECT_FILE_TYPE, "Check File Type");
            }
            if (!File.Exists(path))
            {
                Console.WriteLine("Check File Path or Name");
                throw new CustomExceptioncs(CustomExceptioncs.ExceptionType.FILE_NOT_FOUND, "Check File Path or Name");
            }
            else
            {
                Analyser(path);
            }
        }
        //UC-2
        public int StateCodeAnalyser(string path)
        {
            try 
            {
                if(path.Contains(".csv"))
                {
                    int count;
                    using (StreamReader reader = new StreamReader(path))
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        var items = csv.GetRecords<StateCodeModel>().ToList();
                        count = items.Count();
                        foreach (var item in items)
                        {
                            Console.WriteLine(item.SrNo + "\n" + item.State + "\n" + item.TIN + "\n" + item.StateCode);
                            Console.WriteLine("=======================");
                        }
                        Console.WriteLine(count);
                        return count;
                    }
                }
                else
                {
                    Console.WriteLine("Check File type");
                    throw new CustomExceptioncs(CustomExceptioncs.ExceptionType.INCORRECT_FILE_TYPE, "Check File Type");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Check File Name");
                throw new CustomExceptioncs(CustomExceptioncs.ExceptionType.FILE_NOT_FOUND, "Check File Name");
            }          
        }
    }
}
