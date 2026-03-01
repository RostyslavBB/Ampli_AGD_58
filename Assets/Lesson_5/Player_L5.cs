using UnityEngine;

public class Player_L5 : Character_L5, IMovable
{
    public void Jump()
    {
        Debug.Log("Jump");
    }

    public void Move()
    {
        Debug.Log("Move");
    }

    protected override void SayHello()
    {
        Debug.Log("Player say hello");
    }
}
