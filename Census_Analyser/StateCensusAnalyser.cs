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
            int count;
            using (StreamReader reader = new StreamReader(path))
            using (var csv = new CsvReader(reader,CultureInfo.InvariantCulture))
            {
                var items = csv.GetRecords<CensusModel>().ToList();
                count = items.Count();
                foreach(var item in items)
                {
                    Console.WriteLine(item.State+"\n"+item.Population+"\n"+item.AreaInSqKm+"\n"+item.DensityPerSqKm);
                    Console.WriteLine("=======================");
                }     
                return count;
            }
        }
    }
}
