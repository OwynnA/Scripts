using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class SpriteIDDataList : ScriptableObject
{
    public List<SpriteID> SpriteIDList;

    public SpriteID currentSprite;
    private int num;

    public void SetCurrentIDRandomly()
    {
        num = Random.Range(0, SpriteIDList.Count);
        currentSprite = SpriteIDList[num];
    }
}
