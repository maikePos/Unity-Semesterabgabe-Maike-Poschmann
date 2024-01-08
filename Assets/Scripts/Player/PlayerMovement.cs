using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed; //eine Methode,die im Script die Bewegungsgeschwindigkeit angeben soll und au�erhalb des Scriptes bearbeitet werden kann
    public Rigidbody2D rb2d; //Referenzen f�r die angelegte Komponente "Rigidbody 2D" auf dem GameObject Player

    private Vector2 moveInput; //Methode f�r das neue Input System, um ein GameObject zu bewegen
                               // Vector 2, weil es ein 2D Spiel ist

    private void Update() //Unity-Funktion, die jeden Frame neu kontrolliert, ob etwas geschehen soll
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");  //mit a/d oder left/right kann der Player sich horizontal bewegen
        moveInput.y = Input.GetAxisRaw("Vertical"); //mit w/s oder up/down kann der Player sich vertikal bewegen

        moveInput.Normalize(); //GameObject beh�lt Richtung bei, aber die L�nge wird um 1 verl�ngert

        rb2d.velocity = moveInput * moveSpeed * Time.deltaTime; // hier wird die Geschwindigkeit des Rigidbodys des dazugeh�rigen GameObjects festgelegt
                                                                // die Bewegung in eine der vier Richtungen (-1, 0, 1) wird mit der Methode, die die Geschwindigkeit festlegt multipliziert
                                                                
    }


}
