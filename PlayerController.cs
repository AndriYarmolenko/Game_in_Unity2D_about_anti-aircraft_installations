using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
   
    

    
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
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }
}