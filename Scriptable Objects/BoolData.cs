using UnityEngine;

[CreateAssetMenu]

public class BoolData : ScriptableObject
{
    public bool value = false;

    public void SwitchValue()
    {
        value = !value;
    }
    public void SetValueTrue()
    {
        value = true;
    }

    public void SetValueFalse()
    {
        value = false;
    }
}