using UnityEngine;

public class EnemySpawner_L6 : MonoBehaviour
{
    [SerializeField] private Enemy_L6[] _enemies = new Enemy_L6[3];

    [SerializeField] private Transform _spawnPoint;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            _enemies[0].Attack();
            _enemies[0].MagicAttack();
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            _enemies[1].Attack();
            _enemies[1].MagicAttack();
        }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            _enemies[2].Attack();
            _enemies[2].MagicAttack();
        }
    }
}
