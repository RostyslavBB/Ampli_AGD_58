using UnityEngine;

public class Hero : MonoBehaviour
{
    [SerializeField] private Dragon _dragon;

    [SerializeField] private Lion _lion;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            if (_dragon != null)
                _dragon.TakeDamage(20);

            if (_lion != null)
                _lion.TakeDamage(53);
        }
    }
}
