using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    //public bool isPaused;
    public void Options() //öffentliche Methode für den Button, um auf die Einstellungen des Spiels zuzugreifen
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Additive); // Unity, soll beim betätigen des Buttons die Szene "Settings" laden
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        //SceneManager.UnloadScene("Settings");
        Time.timeScale = 1f; // setzt die "Uhr" auf 1, damit Unity weitermachen kann
        //isPaused = false;
    }
}
