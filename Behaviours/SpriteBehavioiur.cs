using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavioiur : MonoBehaviour
{
    private SpriteRenderer rendererObj;

    private void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRendererColor(ColorIDDataList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }

    public void ChangeRendererSprite(SpriteID newSpriteID)
    {
        rendererObj.sprite = newSpriteID.newSprite;
    }

    public void ChangeRendererSprite(SpriteIDDataList obj)
    {
        rendererObj.sprite = obj.currentSprite.newSprite;
    }

}
