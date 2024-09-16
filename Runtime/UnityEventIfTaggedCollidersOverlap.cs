using UnityEngine;


[RequireComponent(typeof(Collider))]
public class UnityEventIfTaggedCollidersOverlap : AdditionalUnityEvent
{
    [SerializeField] private string m_tagToCheckAgainst = "MainCamera";
    private Collider _thisCollider;


    private void Awake()
    {
        _thisCollider = GetComponent<Collider>();
    }


    public void CheckIfCollidersOverlap()
    {
        var taggedGameObject = GameObject.FindGameObjectWithTag(m_tagToCheckAgainst);

        if (taggedGameObject == null)
        {
            Debug.LogError("No GameObject with tag " + m_tagToCheckAgainst + " found");

            return;
        }

        var taggedCollider = taggedGameObject.GetComponent<Collider>();

        if (_thisCollider.bounds.Intersects(taggedCollider.bounds))
        {
            FireEvent();
        }
    }
}