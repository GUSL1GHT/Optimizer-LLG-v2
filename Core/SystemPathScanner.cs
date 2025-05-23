
using System;
using System.IO;

namespace OptimizerLLG.Core
{
    public static class SystemPathScanner
    {
        public static void Scan(string outputFile)
        {
            var drives = DriveInfo.GetDrives();
            using (var writer = new StreamWriter(outputFile)) // Corregido: usar sintaxis clásica
            {
                writer.WriteLine("Listado de unidades detectadas:");
                foreach (var d in drives)
                    writer.WriteLine(d.Name);
            }
        }
    }
}
