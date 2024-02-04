using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class MatchBehaviour : MonoBehaviour
{
    public ID IDObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if(tempObj == null)
        {
            yield break;
        }
        var otherID = tempObj.IDObj;
        {
            if(otherID == IDObj)
            {
                matchEvent.Invoke();
            }
            else
            {
                noMatchEvent.Invoke();
                yield return new WaitForSeconds(0.5f);
                noMatchDelayedEvent.Invoke();
            }
        }
    }
}
