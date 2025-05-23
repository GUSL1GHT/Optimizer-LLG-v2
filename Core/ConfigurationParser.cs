
using System;
using System.IO;

namespace OptimizerLLG.Core
{
    public static class ConfigurationParser
    {
        public static void ValidateConfiguration(string configPath)
        {
            if (!File.Exists(configPath))
                throw new FileNotFoundException("Archivo de configuración no encontrado.", configPath);

            var lines = File.ReadAllLines(configPath);
            foreach (var line in lines)
            {
                var parts = line.Split(','); // Corregido: usar ',' en vez de 44
                if (parts.Length < 2)
                    throw new FormatException("Formato inválido en configuración.");
            }
        }
    }
}
