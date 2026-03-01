using UnityEngine;

public class TestEnemy : MonoBehaviour
{
    [SerializeField] private int _enemyCurrentHp;
    [SerializeField] private int _enemyMinHp = 0;
    [SerializeField] private int _enemyMaxHp = 100;

    private void Awake()
    {
        _enemyCurrentHp = _enemyMaxHp;
    }

    public void TakeDamage(int damage)
    {
        _enemyCurrentHp -= damage;

        if(_enemyCurrentHp <= _enemyMinHp)
            Death();
    }

    private void Death()
    {
        Destroy(gameObject);
    }
}
