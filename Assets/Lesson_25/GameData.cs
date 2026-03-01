using UnityEngine;

namespace Lesson25
{
    public static class GameData 
    {
        public static void SaveIntData(string key, int coins)
        {
            PlayerPrefs.SetInt(key, coins);
        }

        public static int GetIntData(string key)
        {
            return PlayerPrefs.GetInt(key);
        }
    }
}