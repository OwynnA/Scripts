using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class DraggableBehaviour : MonoBehaviour
{
    private Camera cameraObj;
    public bool draggable;
    private Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    private Rigidbody2D rb;

    void Start()
    {
        cameraObj = Camera.main;
        rb = GetComponent<Rigidbody2D>();
        
    }

    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        yield return new WaitForFixedUpdate();
        draggable = true;
        startDragEvent.Invoke();

        while (draggable)
        {
            rb.gravityScale = 0f;
            yield return new WaitForFixedUpdate();
            position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
            transform.position = position;

        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        endDragEvent.Invoke();
        rb.gravityScale = 1f;
    }
}
