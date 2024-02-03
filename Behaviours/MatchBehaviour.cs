using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID IDObj;
    public UnityEvent matchEvent, noMatchEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        if(tempObj == null)
        {
            return;
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
            }
        }
    }
}
