using Lesson26;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Lesson25
{
    public static class SaveSystem
    {
        private static readonly string _path = Application.persistentDataPath + "/inventorySave.json";

        public static void Save(List<ItemData> inventory)
        {
            ItemDataList wrapper = new();

            wrapper.ItemsData = inventory;

            string json = JsonUtility.ToJson(wrapper, true);

            File.WriteAllText(_path, json);
        }

        public static List<ItemData> Load()
        {
            if (!File.Exists(_path))
            {
                Debug.LogWarning("File doesn't exists");

                return new();
            }

            string json = File.ReadAllText(_path);

            ItemDataList wrapper = JsonUtility.FromJson<ItemDataList>(json);

            return wrapper.ItemsData;
        }
    }
}