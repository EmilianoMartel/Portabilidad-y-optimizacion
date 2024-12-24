using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GesturesTest : MonoBehaviour
{
    private Vector2 fingerStart;
    private Vector2 fingerEnd;

    [SerializeField] TMP_Text infoText;

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                fingerStart = touch.position;
                fingerEnd = touch.position;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                string info = "";

                fingerEnd = touch.position;

                if ((fingerStart.x - fingerEnd.x) < -80)
                {
                    info += "moviendo de izq a der  ";
                }
                else if ((fingerStart.x - fingerEnd.x) > 80)
                {
                    info += "moviendo de der a izq  ";
                }

                if ((fingerStart.y - fingerEnd.y) < -80)
                {
                    info += "moviendo de abajo a arriba a izq";
                }
                else if ((fingerStart.y - fingerEnd.y) > 80)
                {
                    info += "moviendo de arriba a abajo a der";
                }

                fingerStart = touch.position;
                infoText.text = info;
            }
            if (touch.phase == TouchPhase.Ended)
            {
                fingerStart = Vector2.zero;
                fingerEnd = Vector2.zero;
            }
        }
    }
}
