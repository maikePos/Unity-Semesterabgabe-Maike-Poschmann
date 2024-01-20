using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 1f; //eine Methode,die im Script die Bewegungsgeschwindigkeit angeben soll und außerhalb des Scriptes bearbeitet werden kann
    public Rigidbody2D rb; //Referenzen für die angelegte Komponente "Rigidbody 2D" auf dem GameObject Player
    public Animator anim;
    private Vector2 moveInput; //Methode für das neue Input System, um ein GameObject zu bewegen
                               // Vector 2, weil es ein 2D Spiel ist
   

    






    private void Update() //Unity-Funktion, die jeden Frame neu kontrolliert, ob etwas geschehen soll
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");  //mit a/d oder left/right kann der Player sich horizontal bewegen
        moveInput.y = Input.GetAxisRaw("Vertical"); //mit w/s oder up/down kann der Player sich vertikal bewegen

         //GameObject behält Richtung bei, aber die Länge wird um 1 verlängert

        rb.velocity = moveInput * moveSpeed * Time.deltaTime; // hier wird die Geschwindigkeit des Rigidbodys des dazugehörigen GameObjects festgelegt
                                                              // die Bewegung in eine der vier Richtungen (-1, 0, 1) wird mit der Methode, die die Geschwindigkeit festlegt multipliziert
        Animate();
        
    }

    void Animate()
    {
        anim.SetFloat("AnimMoveX", moveInput.x);
        anim.SetFloat("AnimMoveY", moveInput.y);
        anim.SetFloat("AnimMoveMagnitude", moveInput.magnitude);
    }


}
