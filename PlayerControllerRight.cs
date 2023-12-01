using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerRight : MonoBehaviour
{
    public float moveSpeed = 5f;
   
    public void onClick()
    {
        Debug.Log("клик");

    }

    
    bool Pressed = false;
    public void onDown()
    {
        Pressed = true;
    }

    public void onUp()
    {
        Pressed = false;
    }

    void Update() {
        if (Pressed) 
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }
}