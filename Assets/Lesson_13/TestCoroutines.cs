using System.Collections;
using UnityEngine;

public class TestCoroutines : MonoBehaviour
{
    [SerializeField] private bool _isDead;

    [SerializeField] private int _hp = 100;

    private IEnumerator _coroutine;

    private void Start()
    {
        _coroutine = StartDialog();

        StartCoroutine(_coroutine);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            StopCoroutine(_coroutine);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            _hp -= 10;

            CheckPlayerDeath();
        }
    }

    private void CheckPlayerDeath()
    {
        if(_hp <= 0)
            _isDead = true;
    }

    private IEnumerator StartDialog()
    {
        Debug.Log(1);

        yield return new WaitUntil(() => _isDead);

        Debug.Log(2);
    }
}
