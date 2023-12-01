using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mega : MonoBehaviour
{
    public float minX = -5.86f; // Мінімальна x-координата
    public float maxX = 6.48f; // Максимальна x-координата
    public float minY = -3.233f; // Мінімальна y-координата
    public float maxY = -3.233f; // Максимальна y-координата

    void Update()
    {
        // Отримуємо поточну позицію гравця
        Vector3 currentPosition = transform.position;

        // Керуємо рухом по осі x
        float newX = Mathf.Clamp(currentPosition.x, minX, maxX);

        // Керуємо рухом по осі y
        float newY = Mathf.Clamp(currentPosition.y, minY, maxY);

        // Оновлюємо позицію гравця з обмеженнями
        transform.position = new Vector3(newX, newY, currentPosition.z);
    }
}
