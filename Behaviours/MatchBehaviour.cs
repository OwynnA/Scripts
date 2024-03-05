using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class MatchBehaviour : MonoBehaviour
{
    public ID IDObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelayedEvent;
    
    private IEnumerator OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("trigger");
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        Debug.Log(tempObj);
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
