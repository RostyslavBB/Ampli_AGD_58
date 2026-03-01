using System.Text;
using TMPro;
using UnityEngine;

public class WhileTest : MonoBehaviour
{
    [SerializeField] private TMP_Text _agesListText;

    private const int AgesConst = 5;

    private readonly int[,] _ages = new int[AgesConst, AgesConst];

    private void Start()
    {

        StringBuilder stringBuilder = new();

        for (int i = 0; i < AgesConst; i++)
        {
            for (int j = 0; j < AgesConst; j++)
            {
                _ages[i, j] = Random.Range(1, 18);

                stringBuilder.Append(_ages[i, j]);
                stringBuilder.Append(" ");
            }

            stringBuilder.Append("\n");
        }

        _agesListText.text = stringBuilder.ToString();
    }
}
