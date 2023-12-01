using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Додайте цей імпорт для роботи з сценами.

public class GO : MonoBehaviour
{
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Turel") || collision.gameObject.CompareTag("Enemy"))
        {
            // Виклик функції завершення гри.
            GameOverFunction();
        }
    }

    void GameOverFunction()
    {
        // Ваш код для завершення гри, наприклад, відображення екрану завершення гри.
        // Тут також можна використовувати SceneManager для перехоплення гри.
        // Приклад перехоплення гри на інший екран.
        SceneManager.LoadScene("LEVEL");
    }

   
}
