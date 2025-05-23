using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace OptimizerLLG.Core
{
    public static class Analyzer
    {
        public static void AnalyzeSystem()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Output", "hardware_log.csv");
            if (!File.Exists(path))
            {
                Console.WriteLine("No se encontró el archivo de log de hardware.");
                return;
            }

            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                if (line.Contains("GPU"))
                {
                    Console.WriteLine("Entrada de GPU detectada: " + line);
                }
            }
        }
    }
}
