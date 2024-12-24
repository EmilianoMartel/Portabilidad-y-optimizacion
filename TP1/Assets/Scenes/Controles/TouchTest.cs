using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TouchTest : MonoBehaviour
{
    [SerializeField] TMP_Text infoText;

    void Update()
    {
        string info = "";

        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touchData = Input.GetTouch(i);
            info += "Touch " + touchData.fingerId;
            info += "\n Fase: " + touchData.phase.ToString();
            info += "\n Posición: " + touchData.position.x + ", " + touchData.position.y;
            info += "\n Delta Position: " + touchData.deltaPosition.x + ", " + touchData.deltaPosition.y;
            info += "\n Tap count: " + touchData.tapCount;
            info += "\n ----- \n";
        }

        if (!string.IsNullOrEmpty(info))
            info += "\n -- END FRAME -- \n";

        infoText.text += info;
    }
}
