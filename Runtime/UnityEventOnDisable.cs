public class UnityEventOnDisable : AdditionalUnityEvent
{
    private void OnDisable()
    {
        FireEvent();
    }
}