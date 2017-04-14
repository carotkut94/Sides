using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotor : MonoBehaviour
{
    int flag = 0;
    void Start()
    {

    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.touches[0];
            if (touch.phase == TouchPhase.Began && flag == 0)
            {
                iTween.RotateAdd(this.gameObject, iTween.Hash("z", 45.0f, "delay", 0, "time", 0.25f, "easetype", iTween.EaseType.linear));
                flag = 1;
            }
            if(touch.phase == TouchPhase.Ended && flag==1)
            {
                flag = 0;
            }

        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            iTween.RotateAdd(this.gameObject, iTween.Hash("z", 45.0f, "delay", 0, "time", 0.25f, "easetype", iTween.EaseType.linear));
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision Detected");
    }
}
