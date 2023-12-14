using System;
using System.IO;
using System.Reflection;

namespace TheColorsMod_C21341
{
    public class ModInit_C21341 : ModInitializer
    {
        public override void OnInitializeMod()
        {
            TheColorsModParameters.Path =
                Path.GetDirectoryName(
                    Uri.UnescapeDataString(new UriBuilder(Assembly.GetExecutingAssembly().CodeBase).Path));
        }
    }
}