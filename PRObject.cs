using System.Collections;
using UnityEngine;

public class PRObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Перевірка тегу об'єкта, з яким стався зіткнення
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Wall"))
        {
            // Знищення об'єкта "PR" при зіткненні з "Enemy" або "Wall"
            Destroy(gameObject);
        }
    }
}
