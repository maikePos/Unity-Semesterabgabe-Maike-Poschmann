using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // erstellte Referenz (bin mir unsicher, ob das so genannt wird)

public class BackToMainMenu : MonoBehaviour
{
    public void BackToMain()  //eine �ffentliche Methode, die ich nach ihrem Nutzen benannt habe
    {
        SceneManager.LoadScene("SampleScene");  //um den SceneManager nutzen zu k�nnen, habe ich erstmal eine Referenz erstellt
    }                                           //Ich sage dem SceneManagaer, dass wenn der Button mit der Methode BackToMain gedr�ckt wird,
                                                //die Szene geladen werden soll "SampleScene", welches das Hauptmen� ist
}
