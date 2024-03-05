using UnityEngine;

public class DisableTrigger : MonoBehaviour
{
    // Reference to the BoxCollider component
    private BoxCollider2D boxCollider;

    private void Start()
    {
        // Get the BoxCollider component attached to this GameObject
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
  
        boxCollider.enabled = false;
        
    }
}
