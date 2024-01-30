using UnityEngine;

[CreateAssetMenu]

public class BoolData : ScriptableObject
{
    public bool value = False;

    public class SwitchValue()
    {
        value = !value;
    }
    public class SetValueTrue()
    {
        value = True;
    }

    public class SetValueFalse()
    {
        value = False;
    }
}