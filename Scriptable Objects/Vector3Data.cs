using UnityEngine;

[CreateAssetMenu]

public class Vector3Data : ScriptableObject
{
   public Vector3 value;
   public Vector3 lastPos;

   public class UpdatePosition(Transform obj)
   {
        lastPos = obj.position;
        value = obj.position;
   }

   public class UpdateValue(Transform obj)
   {
        obj.position = value;
   }

   public class ReturnToLastPos(Transfrom obj)
   {
        obj.position = lastPos;
   }
}