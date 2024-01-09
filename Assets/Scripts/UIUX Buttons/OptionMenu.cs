using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    //public bool isPaused;
    public void Options() //�ffentliche Methode f�r den Button, um auf die Einstellungen des Spiels zuzugreifen
    {
        SceneManager.LoadScene("Settings", LoadSceneMode.Additive); // Unity, soll beim bet�tigen des Buttons die Szene "Settings" laden
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        //SceneManager.UnloadScene("Settings");
        Time.timeScale = 1f; // setzt die "Uhr" auf 1, damit Unity weitermachen kann
        //isPaused = false;
    }
}
