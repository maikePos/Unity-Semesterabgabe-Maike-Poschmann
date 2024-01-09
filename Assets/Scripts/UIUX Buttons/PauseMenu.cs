using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool isPaused;

    private void Start()
    {
        pauseMenu.SetActive(false);  // PauseMenu wird beim Start des Spiels deaktiviert
    }

    private void Update() //jeder Frame wird kontrolliert, ob etwas wiederholt werden muss
    {
        if(Input.GetKeyDown(KeyCode.Escape)) // wenn die "Escape" Taste gedrückt wird, dann soll etwas passieren
        { 
          if(isPaused) 
            { 
             ResumeGame();
            }
            else 
            { 
             PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);  // PauseMenu soll aktiviert werden. InGame Uhr muss dafür gestoppt werden
        Time.timeScale = 0f; // setzt die "Uhr" auf 0, damit sie nicht mehr läuft
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);  // PauseMenu soll deaktiviert werden, damit das Spiel weiterlaufen kann
        Time.timeScale = 1f; // setzt die "Uhr" auf 1, damit Unity weitermachen kann
        isPaused = false;
    }
}
