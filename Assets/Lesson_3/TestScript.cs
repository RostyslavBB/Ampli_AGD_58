using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private int _playerMinHp = 0;
    [SerializeField] private int _playerMaxHp = 100;
    [SerializeField] private int _currentPlayerHp = 2;

    private bool _isAlive = true;

    private void Start()
    {
       /* Debug.Log(_currentPlayerHp++); //2 
        Debug.Log(_currentPlayerHp); //3 
        Debug.Log(++_currentPlayerHp); //4*/
    }
}
