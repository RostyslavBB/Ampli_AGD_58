using UnityEngine;

namespace Lesson29
{
    public class CustomButton : MonoBehaviour
    {
        [SerializeField] private UISoundController _UISoundController;

        public virtual void Click()
        {
            _UISoundController.PlaySound();
        }
    }
}