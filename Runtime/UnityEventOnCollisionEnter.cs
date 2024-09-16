using System.Linq;
using UnityEngine;


public class UnityEventOnCollisionEnter : AdditionalUnityEvent
{
    [SerializeField] private Collider[] m_excludeColliders;


    private void OnCollisionEnter(Collision other)
    {
        if (m_excludeColliders.Contains(other.collider))
        {
            return;
        }

        FireEvent();
    }
}