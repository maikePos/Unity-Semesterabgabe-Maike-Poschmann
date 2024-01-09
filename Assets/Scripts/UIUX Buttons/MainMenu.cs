using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // benötigt Unity, um mehrere Szenen zu laden

public class MainMenu : MonoBehaviour
{
    public void PlayGame() //öffentliche Methode für den Button, um das Spiel zu starten
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // "SceneManager.GetActiveScene().buildIndex + 1" : es soll eine Szene
                                                                              // geladen werden, die nach der aktuellen Szene als nächstes kommt
    }

    public void Options() //öffentliche Methode für den Button, um auf die Einstellungen des Spiels zuzugreifen
    {
        SceneManager.LoadScene("Settings"); // Unity, soll beim betätigen des Buttons die Szene "Settings" laden
    }

    public void Credits() //öffentliche Methode für den Button, um auf die Credits des Spiels zuzugreifen
    {
        SceneManager.LoadScene("Credits"); // Unity, soll beim betätigen des Buttons die Szene "Credits" laden
    }
    public void QuitGame() //öffentliche Methode für den Button, um das Spiel zu beenden
    {
        Application.Quit(); // Unity wird gesagt, dass beim betätigen des Buttons "QuitGame", das Spiel beendet werden soll
    }

    public void RestartGame() //öffentliche Methode für den Button, um das Spiel neu zu starten
    {
        SceneManager.LoadScene("Level01");
        Time.timeScale = 1;                                               // SceneManager.GetActiveScene().buildIndex" : die grade aktuelle Szene
    }                                                                     // wird bei Betätigung des Buttons neu gestartet
}
