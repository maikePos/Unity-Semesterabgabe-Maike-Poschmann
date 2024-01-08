using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab; // Referenz für das Prefab des GameObjects "Bullet"
    public Transform spawnPoint; // Methode, die den Anfangsort der Bullet festlegt
    public float shootingRate; // Schussrate, also wie schnell eine Bullet geschossen werden kann
    private float shootingTimer = 0f; //private Methode, da sie im Inspector nicht relevant ist
    public float speed = 10f; // Geschwindihgeit der Bullet

    private void Update()
    {
        shootingTimer += Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.Q) && shootingTimer >= shootingRate)
        {
            Shoot();
            shootingTimer = 0f;
        }
    }

    void Shoot() //private Methode, die keinen Rückgabewert hat und beschreibt, wie die Bullet geschossen werden soll
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Die Mausposition entspricht der Position in der "Welt"
        Vector2 direction = (mousePosition = transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //das kann ich leider nicht erklären

        GameObject newBullet = Instantiate(bulletPrefab, spawnPoint.position, Quaternion.Euler(0, 0, angle)); // erstellt nach "abschießen der Bullet2 eine Kopie des bestehend Prefabs
                                                                                                              // Quaternion.Euler kann ich nicht erklären
        Rigidbody2D bulletRb = newBullet.GetComponent<Rigidbody2D>();

        bulletRb.velocity = direction * speed; //
    }
}
