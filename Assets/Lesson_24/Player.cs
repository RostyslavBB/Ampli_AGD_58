using UnityEngine;

namespace Lesson24
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q)) _animator.SetTrigger("Walk");

            if (Input.GetKeyDown(KeyCode.W)) _animator.SetTrigger("Run");

            if (Input.GetKeyDown(KeyCode.E)) _animator.SetTrigger("Death");
        }
    }
}
