using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDBehaviour : IDContainerBehaviour
{
     public IDDataList IDDataListObj;

    private void Awake()
    {
        IDObj = IDDataListObj.currentID;
    }
}
