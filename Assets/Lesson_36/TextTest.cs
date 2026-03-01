using TMPro;
using UnityEngine;

namespace Lesson36
{
    public class TextTest : MonoBehaviour
    {
        [SerializeField] private TMP_Text _text;

        private void Start()
        {
            _text.ForceMeshUpdate();

            Debug.LogWarning(_text.textInfo.lineCount);

            _text.overflowMode = TextOverflowModes.Truncate;

            _text.ForceMeshUpdate();

            Debug.LogWarning(_text.textInfo.lineCount);
        }
    }
}