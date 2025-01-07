using Respawning;
using SteveAPI.Pools;
using System.Text;

namespace SteveAPI
{
    public static class Cassie
    {
        public static void MessageTranslated(string message, string translation, bool isHeld = false, bool isNoisy = true, bool isSubtitles = true)
        {
            StringBuilder stringBuilder = StringBuilderPool.Pool.Get();
            string[] array = message.Split('\n');
            string[] array2 = translation.Split('\n');
            for (int i = 0; i < array.Length; i++)
            {
                stringBuilder.Append(array2[i].Replace(' ', '\u2005') + "<size=0> " + array[i] + " </size><split>");
            }
            RespawnEffectsController.PlayCassieAnnouncement(stringBuilder.ToString(), isHeld, isNoisy, isSubtitles);
            StringBuilderPool.Pool.Return(stringBuilder);
        }
        public static void Clear() => RespawnEffectsController.ClearQueue();
    }
}
