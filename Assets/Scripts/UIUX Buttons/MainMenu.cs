using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // ben�tigt Unity, um mehrere Szenen zu laden

public class MainMenu : MonoBehaviour
{
    public void PlayGame() //�ffentliche Methode f�r den Button, um das Spiel zu starten
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // "SceneManager.GetActiveScene().buildIndex + 1" : es soll eine Szene
                                                                              // geladen werden, die nach der aktuellen Szene als n�chstes kommt
    }

    public void Options() //�ffentliche Methode f�r den Button, um auf die Einstellungen des Spiels zuzugreifen
    {
        SceneManager.LoadScene("Settings"); // Unity, soll beim bet�tigen des Buttons die Szene "Settings" laden
    }

    public void Credits() //�ffentliche Methode f�r den Button, um auf die Credits des Spiels zuzugreifen
    {
        SceneManager.LoadScene("Credits"); // Unity, soll beim bet�tigen des Buttons die Szene "Credits" laden
    }
    public void QuitGame() //�ffentliche Methode f�r den Button, um das Spiel zu beenden
    {
        Application.Quit(); // Unity wird gesagt, dass beim bet�tigen des Buttons "QuitGame", das Spiel beendet werden soll
    }

    public void RestartGame() //�ffentliche Methode f�r den Button, um das Spiel neu zu starten
    {
        SceneManager.LoadScene("Level01");
        Time.timeScale = 1;                                               // SceneManager.GetActiveScene().buildIndex" : die grade aktuelle Szene
    }                                                                     // wird bei Bet�tigung des Buttons neu gestartet
}
