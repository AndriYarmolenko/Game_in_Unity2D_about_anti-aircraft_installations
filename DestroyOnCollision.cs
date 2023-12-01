using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyOnCollision : MonoBehaviour
{
    public int PRS = 0;

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        Destroy(gameObject);
        PRS++;
        
    }
}
