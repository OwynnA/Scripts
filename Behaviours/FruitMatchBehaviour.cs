using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMatchBehaviour : MatchBehaviour
{
    public SpriteIDDataList spriteIDDataListObj;

    private void Awake()
    {
        IDObj = spriteIDDataListObj.currentSprite; //fix this somehow
    }

    public void ChangeSprite(SpriteRenderer renderer)
    {
        var newSprite = IDObj as SpriteID;
        renderer.sprite = newSprite.newSprite;
    }
}