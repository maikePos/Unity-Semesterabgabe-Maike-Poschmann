using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player; //Referenz für das GameObject "Player"
    public float speed; // Methode, die die Geschwindigkeit des Enemy festlegt
    public float detectionRadius; //Radius, in dem das Enemy den Player erkennen kann

    private bool isFollowing = false; //Methode, die sagt, ob das Enemy dem Player folgt oder nicht

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRadius) // checkt, ob der Abstand zum Player kleiner gleich dem Radius ist
        {
            isFollowing = true; //Wahr/Falsch Methode wird auf wahr gesetzt, da der Player sich im Radius befindet
        }
        else //wenn der Player außerhalb des Radius ist, dann ...
        {
            isFollowing = false; //...Wahr/Falsch Methode wird auf falsch gesetzt, da der Player sich außerhalb des Radius befindet
        }

        if(isFollowing) //wenn der Player im Radius des Enemy ist, dann soll das Enemy der Position des Players folgen mit der festgelegten Geschwindigkeit
        {
            Vector2 direction = (player.position - transform.position).normalized;
            Vector2 movement = direction * speed * Time.deltaTime;
            transform.Translate(movement);
        }
    }
}
