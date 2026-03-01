using UnityEngine;

public class Dragon : MonoBehaviour, IDamagable
{
    [SerializeField] private int _hp = 100;

    public void TakeDamage(int damage)
    {
        _hp -= damage;

        if( _hp <= 0 )
            Death();
    }

    public void Death()
    {
        Destroy(gameObject);
    }
}
