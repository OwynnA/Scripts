using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(text))]

public class TextLabelBehaviour : Monobehaviour
{
    public Text label;
    public FloatData dataObj;

    private void Start()
    {
        label = GetComponent<text>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}