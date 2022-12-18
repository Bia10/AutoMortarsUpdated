using Verse;

namespace AutoMortarsUpdated.Source;

[StaticConstructorOnStartup]
internal class Patcher
{
    static Patcher()
    {
        Log.Message("AutoMortarsUpdated: Starting ...");

        // Todo: patching

        Log.Message("AutoMortarsUpdated: Complete.");
    }
}