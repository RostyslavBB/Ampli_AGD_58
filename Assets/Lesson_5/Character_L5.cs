using UnityEngine;

public abstract class Character_L5 : MonoBehaviour
{
    [SerializeField] protected string Name = "None";
    [SerializeField] protected int Hp = 100;
    [SerializeField] protected int Damage = 5;

    private void Start()
    {
        SayHello();
    }

    protected void PrintInfo()
    {
        Debug.Log(Name + " " + Hp + " " + Damage);
    }

    protected abstract void SayHello();
}
