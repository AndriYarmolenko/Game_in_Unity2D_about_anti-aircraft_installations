using UnityEngine;

public class Stop : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && !isPaused)
        {
            Pause();
        }
        else if (Input.GetKeyDown(KeyCode.P) && isPaused)
        {
            Resume();
        }
    }

    void Pause()
    {
        Time.timeScale = 0f; // Зупиняємо час у грі.
        isPaused = true;
    }

    void Resume()
    {
        Time.timeScale = 1f; // Відновлюємо час у грі.
        isPaused = false;
    }
}
