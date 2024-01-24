using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    public void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}