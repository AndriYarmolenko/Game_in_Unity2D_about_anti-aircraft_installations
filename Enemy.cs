using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int points = 1; // Кількість балів, які отримуєте за знищення ворога.

    private void OnDestroy()
    {
        // Збільшуємо бали при знищенні ворога.
        FindObjectOfType<ScoreManager>().AddScore(points);
    }
}
