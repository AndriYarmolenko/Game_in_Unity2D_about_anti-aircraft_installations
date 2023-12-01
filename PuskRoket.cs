using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuskRoket : MonoBehaviour
{
    public GameObject rocketPrefab;
    public float rocketSpeed = 5f;
    private GameObject currentRocket;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentRocket == null)
        {
            LaunchRocket();
        }
    }

    void LaunchRocket()
    {
        currentRocket = Instantiate(rocketPrefab, transform.position, Quaternion.identity);
        Rigidbody2D rocketRigidbody = currentRocket.GetComponent<Rigidbody2D>();

        // Рух ракети вправо (можна змінити напрямок)
        rocketRigidbody.velocity = Vector2.right * rocketSpeed;
    }
}
