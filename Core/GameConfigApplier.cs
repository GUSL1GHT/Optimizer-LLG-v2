using System.IO;
namespace OptimizerLLG.Core
{
    public static class GameConfigApplier
    {
        public static void Apply(string gameFile)
        {
            var dest = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "GameUserSettings.ini");
            File.Copy(gameFile, dest, true);
        }
    }
}