using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteIDBehaviour : IDContainerBehaviour
{
   public SpriteIDDataList spriteIDDataListObj;

    private void Awake()
    {
        IDObj = spriteIDDataListObj.currentSprite;
    }
}
