using UnityEngine;

namespace Lesson22
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _jumpSpeed;

        [SerializeField] private Animator _animator;

        private float _startYPosition;

        private bool _isJumping;
        private bool _isFalling;

        private void Awake()
        {
            _startYPosition = transform.position.y;
        }

        private void Update()
        {
            float moveX = Input.GetAxis("Horizontal");
            float moveZ = Input.GetAxis("Vertical");

            Vector3 movement = new(moveX, 0f, moveZ);

            bool isMoving = movement.magnitude > 0f;

            _animator.SetBool("isWalking", isMoving);

            transform.Translate(_speed * Time.deltaTime * movement);

            if (Input.GetKeyDown(KeyCode.Space) && !_isJumping)
            {
                Jump();
            }

            Fall();
        }

        private void Jump()
        {
            _isJumping = true;

            _animator.SetTrigger("Jump");

            if(_isJumping)
            {
                transform.Translate(Vector3.up * _jumpSpeed);

                if(transform.position.y >= _startYPosition)
                {
                    _isJumping = false;
                    _isFalling = true;
                }
            }
        }

        private void Fall()
        {
            if (_isFalling)
            {
                transform.Translate(Vector3.down * _jumpSpeed * Time.deltaTime);

                if (transform.position.y <= _startYPosition)
                {
                    Vector3 startPosition = new(transform.position.x, transform.position.y, transform.position.z);

                    startPosition.y = _startYPosition;

                    transform.position = startPosition;

                    _isFalling = false;
                }
            }
        }
    }
}