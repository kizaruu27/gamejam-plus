using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public string targetTag;
    public UnityEvent OnTriggerEvents;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == targetTag)
            OnTriggerEvents.Invoke();
    }
}
