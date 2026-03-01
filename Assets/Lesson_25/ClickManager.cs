using TMPro;
using UnityEngine;

namespace Lesson25
{
    public class ClickManager : MonoBehaviour
    {
        [SerializeField] private PlayerData _playerData;

        [SerializeField] private TMP_Text _coinsText;

        private int _coins = 0;

        private void Awake()
        {
            LoadData();

            SaveSystem.Load();

            _coinsText.text = PlayerData.Level.ToString();
        }

        public void Click()
        {
            _coins++;

            _coinsText.text = _coins.ToString();
        }

        private void SaveData()
        {
            GameData.SaveIntData("coins", _coins);
        }

        private void LoadData()
        {
            _coins = GameData.GetIntData("coins");

            _coinsText.text = _coins.ToString();
        }

        private void OnApplicationQuit()
        {
            SaveData();

         /*   SaveSystem.Save(_playerData);*/
        }
    }
}