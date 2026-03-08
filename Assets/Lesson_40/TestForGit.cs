using UnityEngine;

namespace Lesson_40
{
    public class TestForGit : MonoBehaviour
    {
        private void Start()
        {
            Debug.LogWarning("Hello Git");
            Debug.LogWarning("Hello Gordiy");
            Debug.LogWarning("Hello David");

            SayHello();
        }

        private void SayHello()
        {
            Debug.LogWarning("Hello World");
        }
    }
}