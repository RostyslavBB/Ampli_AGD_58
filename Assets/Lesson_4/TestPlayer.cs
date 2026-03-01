using UnityEngine;

public class TestPlayer : MonoBehaviour
{
    [SerializeField] private int _playerDamage = 20;

    [SerializeField] private TestEnemy _testEnemy;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Attack();
    }

    private void Attack()
    {
        if (_testEnemy == null)
            return;

        _testEnemy.TakeDamage(_playerDamage);
    }
}
