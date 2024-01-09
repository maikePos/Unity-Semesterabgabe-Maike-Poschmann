using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;


[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class NewBullet : MonoBehaviour
{
    [SerializeField] private float speed = 14;
    [SerializeField] private float distanceUntilDespawn = 10;
    [SerializeField] private int damage = 1;
    [SerializeField] private float radius = .25f;
    [SerializeField] private Transform bulletVisuals;

    private Vector2 startPosition;
    private Vector2 travelDirection;

    private void OnValidate()
    {
        GetComponent<CircleCollider2D>().radius = radius;
        if (bulletVisuals != null)
            bulletVisuals.localScale = new Vector3(radius * 2, radius * 2, radius * 2);
    }

    public void Launch(PlayerBase shooter, Vector2 targetedPosition)
    {
        Vector2 direction = targetedPosition - shooter.GetPosition();
        direction.Normalize();

        LaunchInDirection(shooter, direction);
    }

    public void LaunchInDirection(PlayerBase shooter, Vector2 shootDirection)
    {
        startPosition = transform.position;

        Physics2D.IgnoreCollision(GetComponent<Collider2D>(), shooter.GetComponent<Collider2D>());

        GetComponent<Rigidbody2D>().AddForce(shootDirection * speed, ForceMode2D.Impulse);
        travelDirection = shootDirection;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {


        HealthPoints healthPointManager = col.gameObject.GetComponent<HealthPoints>();
        if (healthPointManager != null)
        {
            healthPointManager.TakeDamage(damage);
            
        }

        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        if (Vector2.Distance(startPosition, transform.position) >= distanceUntilDespawn)
        {
            Destroy(gameObject);
        }
    }
}
