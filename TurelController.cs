using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TurelController : MonoBehaviour
{
    public string enemyTag = "Enemy"; // Тег для об'єкта "Enemy"
    private Transform target; // Трансформ цілі
    public float rotationSpeed = 2.0f; // Швидкість обертання турелі


    void Update()
    {
        FindTarget();

        if (target != null)
        {
            // Отримати вектор до цілі
            Vector2 direction = target.position - transform.position;
            direction.Normalize();

            // Обчислити кут обертання турелі
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            
            // Обернути турель в сторону цілі
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, angle), rotationSpeed * Time.deltaTime);
        }
    }

    void FindTarget()
    {
        // Знайти всі об'єкти з тегом "Enemy"
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);

        if (enemies.Length > 0)
        {
            // Знайти найближчого ворога
            float closestDistance = float.MaxValue;

            foreach (var enemy in enemies)
            {
                float distance = Vector3.Distance(transform.position, enemy.transform.position);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    target = enemy.transform;
                }
            }
        }
    }

    
    

    
}
