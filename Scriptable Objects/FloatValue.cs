using UnityEngine;

[CreateAssetMenu(fileName = "test", menuName = "hello")]

public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float num)
    {
        value += num;
    }

    public void ReplaceValue(float num)
    {
        value = num;
    }

}