using UnityEngine;

namespace Lesson21
{
    public class InputManager : MonoBehaviour
    {
        private void Update()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                    Debug.Log("Touch started");

                if (touch.phase == TouchPhase.Moved)
                    Debug.Log("Finger moving");

                if (touch.phase == TouchPhase.Ended)
                    Debug.Log("Touch Ended");
            }
        }
    }
}
