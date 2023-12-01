using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed = 5f; // Швидкість руху гравця
    public float leftBoundary = -5.86f; // Ліва межа
    public float rightBoundary = 6.71f; // Права межа

    void Update()
    {
        // Отримуємо ввід користувача
        float horizontalInput = Input.GetAxis("Horizontal");

        // Рухаємо гравця вліво або вправо
        Vector3 movement = new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Обмеження по горизонталі
        Vector3 currentPosition = transform.position;
        currentPosition.x = Mathf.Clamp(currentPosition.x, leftBoundary, rightBoundary);
        transform.position = currentPosition;
    }
}
