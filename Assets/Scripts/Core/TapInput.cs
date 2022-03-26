using UnityEngine;

namespace Core
{
    public class TapInput : MonoBehaviour
    {
        void Update()
        {
            if (Input.touchCount == 0) return;
            if (Input.touches[0].phase != TouchPhase.Began) return;
            Events.OnTap?.Invoke();
        }
    }
}
