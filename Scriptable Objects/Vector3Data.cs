using UnityEngine;

[CreateAssetMenu]

public class Vector3Data : ScriptableObject
{
   public Vector3 value;
   public Vector3 lastPos;

   public void UpdatePosition(Transform obj)
   {
        lastPos = obj.position;
        value = obj.position;
   }

   public void UpdateValue(Transform obj)
   {
        obj.position = value;
   }

   public void ReturnToLastPos(Transform obj)
   {
        obj.position = lastPos;
   }
}