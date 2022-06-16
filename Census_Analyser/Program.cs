using Census_Analyser;

StateCensusAnalyser analyser = new StateCensusAnalyser();
analyser.Analyser(@"D:\Bridgelabz\.Net\Indian_States_Census_Analyser\Census_Analyser\Files\StateCensusData.csv");
Console.WriteLine("=======================");
analyser.StateCodeAnalyser(@"D:\Bridgelabz\.Net\Indian_States_Census_Analyser\Census_Analyser\Files\StateCode.csv");