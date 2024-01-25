using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchCountTracke : MonoBehaviour
{
    public Text textField;

    private void Update()
    {
        textField.text = Input.touchCount.ToString();
    }

}
