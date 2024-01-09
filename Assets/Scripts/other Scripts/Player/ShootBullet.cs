using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public float distanceUntilDespawn = 10;
    public GameObject bullet;
    public Transform spawnBullet; //Referenz für das vorhandene Child-GameObject des Players
    public float speed; // Geschwindigkeit, die im Inspector bearbeitet werden kann
    Vector2 lookDirection; //Vector, der auf x- und y-Achse zZugriff hat
   
    float lookAngle; 

    private void Update()
    {
       

        lookDirection = Camera.main.WorldToScreenPoint(transform.position); //beschreibt wo die Maus hinzeigt
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg; //kan ich nicht erklären

        spawnBullet.rotation = Quaternion.Euler(0, 0, lookAngle); //kann ich nicht erklären

        if(Input.GetMouseButtonDown(0)) //neues Input System. Wenn die linke Maustaste gedrückt wird, dann...
        {
            GameObject bulletClone = Instantiate(bullet); // ...wird neue Bullet vom Prefab erstellt
            bulletClone.transform.position = spawnBullet.position; // bei der Position des Child-GameObjects des Players
            bulletClone.transform.rotation = Quaternion.Euler(0, 0, lookAngle); //kann ich nicht erklären

            bulletClone.GetComponent<Rigidbody2D>().velocity = spawnBullet.right * speed; //berechnet die Geschwindigkeit der Bullet
        }
    }

    


}
