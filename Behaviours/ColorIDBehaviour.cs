using UnityEngine;

public class ColorIDBehaviour : IDContainerBehaviour
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        IDObj = colorIDDataListObj.currentColor;
    }
}
