using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public float distanceUntilDespawn = 10;
    public GameObject bullet;
    public Transform spawnBullet; //Referenz für das vorhandene Child-GameObject des Players
    public float speed;
    Vector2 lookDirection; //Vector, der auf x- und y-Achse zZugriff hat
   
    float lookAngle; 

    private void Update()
    {
       

        lookDirection = Camera.main.WorldToScreenPoint(transform.position); //beschreibt wo die Maus hinzeigt
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg; //kan ich nicht erklären

        spawnBullet.rotation = Quaternion.Euler(0, 0, lookAngle);

        if(Input.GetMouseButtonDown(0))
        {
            GameObject bulletClone = Instantiate(bullet);
            bulletClone.transform.position = spawnBullet.position;
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle);

            bulletClone.GetComponent<Rigidbody2D>().velocity = spawnBullet.right * speed;
        }
    }

    
}
