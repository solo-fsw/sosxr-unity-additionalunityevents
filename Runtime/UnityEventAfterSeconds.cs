using UnityEngine;


namespace SOSXR.AdditionalUnityEvents
{
    public class UnityEventAfterSeconds : AdditionalUnityEvent
    {
        [SerializeField] private bool m_startOnStart = true;
        [SerializeField] [Range(0f, 60f)] private float m_secondsToWaitAfterCalling = 5f;


        private void Start()
        {
            if (m_startOnStart)
            {
                FireEventAfterDelay();
            }
        }


        [ContextMenu(nameof(FireEventAfterDelay))]
        public void FireEventAfterDelay()
        {
            Invoke(nameof(FireEvent), m_secondsToWaitAfterCalling);

            Debug.LogFormat("Will fire event after {0} seconds", m_secondsToWaitAfterCalling);
        }
    }
}