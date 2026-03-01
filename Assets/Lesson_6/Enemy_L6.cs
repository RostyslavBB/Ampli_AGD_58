using UnityEngine;

public class Enemy_L6 : MonoBehaviour, IAttackable
{
    public virtual void Attack()
    {
        Debug.Log("Enemy attack");
    }

    public virtual void MagicAttack()
    {
        Debug.Log("Enemy magic attack");
    }
}
