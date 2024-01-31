using UnityEngine;
using UnityEngine.Events;

public class MonoEventBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, awakeEvent, disableEvent, enableEvent, destroyEvent, stayEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }
    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnDisable()
    {
        disableEvent.Invoke();
    }

    private void OnEnable()
    {
        enableEvent.Invoke();
    }

    private void OnDestroy()
    {
        destroyEvent.Invoke();
    }

    private void OnCollisionStay()
    {
        stayEvent.Invoke();
    }
}
