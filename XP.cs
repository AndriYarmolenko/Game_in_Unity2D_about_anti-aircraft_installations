using UnityEngine;
using UnityEngine.SceneManagement;

public class XP : MonoBehaviour
{
    public int playerLives = 3; // Початкова кількість життів гравця
    private int enemyCollisions = 0;
    private bool isPaused = false;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Якщо зіткнення відбулось з об'єктом з тегом "Enemy"
            enemyCollisions++; // Збільшуємо лічильник зіткнень з ворогами
            playerLives--; // Зменшуємо кількість життів на 1
            Destroy(collision.gameObject); // Знищуємо ворога

            if (enemyCollisions == 1)
            {
                // Після першого зіткнення, знищуємо об'єкт "XP3"
                GameObject xp3Object = GameObject.FindGameObjectWithTag("XP3");
                if (xp3Object != null)
                {
                    Destroy(xp3Object);
                }
            }
            else if (enemyCollisions == 2)
            {
                // Після другого зіткнення, знищуємо об'єкт "XP2"
                GameObject xp2Object = GameObject.FindGameObjectWithTag("XP2");
                if (xp2Object != null)
                {
                    Destroy(xp2Object);
                }
            }
            else if (enemyCollisions == 3)
            {
                // Після третього зіткнення
                // Знищуємо гравця і об'єкт "XP"
                Destroy(gameObject); // Знищуємо гравця
                GameObject xpObject = GameObject.FindGameObjectWithTag("XP");
                if (xpObject != null)
                {
                    Destroy(xpObject);
                    
                }
                LevelManager.manager.GameOver();
            }
        }
    }
       
        
        
            
        
    
}
