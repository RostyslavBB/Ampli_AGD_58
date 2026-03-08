using TMPro;
using UnityEngine;

namespace Lesson40
{
    public class UiUpdater : MonoBehaviour
    {
        [SerializeField] private TMP_Text _textMeshPro;
        [SerializeField] private float _currentScore;

        public void UpdateScore(float score)
        {
            _currentScore += score;
            _textMeshPro.text = _currentScore.ToString();
        }
    }
}
