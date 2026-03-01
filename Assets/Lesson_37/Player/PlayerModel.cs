using UnityEngine;

namespace Lesson37.Player
{
    public class PlayerModel
    {
        public float CurrentHealth { get; private set; }

        public bool IsRunnig { get; set; }

        public PlayerSettings PlayerSettings { get; private set; }

        public PlayerModel(PlayerSettings playerSettings)
        {
            PlayerSettings = playerSettings;
        }

        public void Initialize()
        {
            CurrentHealth = PlayerSettings.MaxHealth;
        }

        public void TakeDamage(float damage)
        {
            CurrentHealth -= damage;

            if (CurrentHealth < 0) CurrentHealth = 0;
        }

        public void Heal()
        {
            CurrentHealth += PlayerSettings.HealAmount;

            if (CurrentHealth >= PlayerSettings.MaxHealth) CurrentHealth = PlayerSettings.MaxHealth;
        }
            
        public Vector3 GetRandomPosition(Transform playerTransform)
        {
            float positionX = Random.Range(playerTransform.position.x - PlayerSettings.TeleportLenght,
                playerTransform.position.x + PlayerSettings.TeleportLenght);

            float positionZ = Random.Range(playerTransform.position.z - PlayerSettings.TeleportLenght,
                playerTransform.position.z + PlayerSettings.TeleportLenght);

            Vector3 newPosition = new(positionX, playerTransform.position.y, positionZ);

            return newPosition;
        }

        public Vector3 CalculateMovement()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            Vector3 direction = new(horizontal, 0, vertical);

            return direction.normalized;
        }
    }
}
