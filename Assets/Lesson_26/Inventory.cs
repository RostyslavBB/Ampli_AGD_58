using Lesson25;
using System.Collections.Generic;
using UnityEngine;

namespace Lesson26
{
    public class Inventory : MonoBehaviour
    {
        private List<ItemData> _itemDatas = new();

        private void Awake()
        {
            List<ItemData> itemDataList = SaveSystem.Load();

            foreach (ItemData item in itemDataList)
            {
                Debug.Log($"Name : {item.Name}, id: {item.Id}");
            }
        }

        public void Start()
        {
            ItemData itemData1 = new();
            ItemData itemData2 = new();

            itemData1.Id = 0;
            itemData1.Name = "Sword";

            itemData2.Id = 1;
            itemData2.Name = "Bow";

            _itemDatas.Add(itemData1);
            _itemDatas.Add(itemData2);

            SaveSystem.Save(_itemDatas);
        }
    }
}