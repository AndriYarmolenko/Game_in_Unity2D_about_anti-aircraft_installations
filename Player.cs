using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firingPoint;
    [Range(0.1f, 2f)]
    [SerializeField] private float fireRate = 0.5f;

    private float fireTimer;
    
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && fireTimer <= 0f)
        {
            Shoot();
            fireTimer = fireRate;
        } else {
            fireTimer -= Time.deltaTime;
        }

    }

    private void Shoot()
    {

        Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation);

    }
}
