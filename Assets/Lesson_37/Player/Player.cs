using UnityEngine;

namespace Lesson37.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private PlayerView _playerView;
        [SerializeField] private PlayerSettings _playerSettings;

        private PlayerPresenter _playerPresenter;

        private void Awake()
        {
            PlayerModel playerModel = new(_playerSettings);

            _playerPresenter = new(_playerView, playerModel);

            _playerPresenter.Initialize();
        }

        private void Update()
        {
            _playerPresenter.Move();

            if (Input.GetKeyUp(KeyCode.T))
            {
                _playerPresenter.TakeDamage(10);
            }
            if (Input.GetKeyUp(KeyCode.Y))
            {
                _playerPresenter.Heal();
            }
            if (Input.GetKeyUp(KeyCode.R))
            {
                _playerPresenter.TeleportRandomPosition(transform);
            }

            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                _playerPresenter.BeginRun();
            }
            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _playerPresenter.EndRun();
            }
        }
    }
}