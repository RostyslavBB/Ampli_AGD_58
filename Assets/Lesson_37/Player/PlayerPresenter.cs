using UnityEngine;

namespace Lesson37.Player
{
    public class PlayerPresenter 
    {
        private readonly PlayerView _playerView;
        private readonly PlayerModel _playerModel;

        public PlayerPresenter(PlayerView playerView, PlayerModel playerModel)
        {
            _playerView = playerView;
            _playerModel = playerModel;
        }

        public void Initialize()
        {
            _playerModel.Initialize();

            _playerView.UpdatePlayerHealthText(_playerModel.CurrentHealth);
        }

        public void TakeDamage(float damage)
        {
            _playerModel.TakeDamage(damage);

            _playerView.UpdatePlayerHealthText(_playerModel.CurrentHealth);

            if(_playerModel.CurrentHealth <= 0) _playerView.Death();
        }

        public void Heal()
        {
            _playerModel.Heal();

            _playerView.UpdatePlayerHealthText(_playerModel.CurrentHealth);
        }

        public void TeleportRandomPosition(Transform playerTransform)
        {
            _playerView.TeleportRandomPosition(_playerModel.GetRandomPosition(playerTransform));
        }

        public void Move()
        {
            if(_playerModel.IsRunnig)
                _playerView.Move(_playerModel.CalculateMovement(), _playerModel.PlayerSettings.RunSpeed);
            else
                _playerView.Move(_playerModel.CalculateMovement(), _playerModel.PlayerSettings.WalkSpeed);
        }

        public void BeginRun()
        {
            _playerModel.IsRunnig = true;

        }

        public void EndRun()
        {
            _playerModel.IsRunnig = false;
        }
    }
}