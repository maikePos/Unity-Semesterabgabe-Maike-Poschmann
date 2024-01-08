using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    public int maximumHitPoints; // Anzahl an maximalen Trefferpunkten
    public int currentHitPoints; // aktuelle Trefferpunkte

    private void Awake() //Methode, die noch vor der start methode aufgerufen wird
    {
        currentHitPoints = maximumHitPoints; //am Anfang des Spieles sollen die aktuellen Trefferpunkte den maximalen entsprechen
    }

    public void TakeDamage(int damageAmount) // Methode, für wenn der Player Schaden nimmt
    {
        currentHitPoints -= damageAmount; //den aktuellen trefferpunkten wird immer -1 Einheit abgezogen

        if (currentHitPoints <= 0) // wenn die aktuellen Trefferpunkte kleiner gleich 0 sind, dann soll das GameObject mit diesem Script zerstört werden
            Destroy(gameObject);
    }
}
