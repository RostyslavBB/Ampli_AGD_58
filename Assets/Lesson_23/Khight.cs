using UnityEngine;

namespace Lesson23
{
    public class Khight : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
                _animator.SetTrigger("Idle");
            if (Input.GetKeyDown(KeyCode.W))
                _animator.SetTrigger("Walk");
            if (Input.GetKeyDown(KeyCode.E))
                _animator.SetTrigger("Attack");
        }
    }
}
