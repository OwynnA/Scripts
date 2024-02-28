using UnityEngine;

public class ColorMatchBehaviour : MatchBehaviour
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        IDObj = colorIDDataListObj.currentColor;
    }

    public void ChangeColor(SpriteRenderer renderer)
    {
        var newColor = IDObj as ColorID;
        renderer.color = newColor.value;
    }
}
