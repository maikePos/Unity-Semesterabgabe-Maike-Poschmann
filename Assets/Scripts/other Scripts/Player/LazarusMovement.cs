using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazarusMovement : MonoBehaviour
{
    [SerializeField] public Rigidbody2D rb;
    public Animator anim;
    private float speed = 2f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        Move();

    }



    public void Move()
    {

        // Debug.Log("You can move now.");

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);
        movement.Normalize(); // Ensure diagonal movement isn't faster
        rb.velocity = movement * speed;


    }

    void Animate()
    {
        anim.SetFloat("AnimMoveX", speed);
    }

}
