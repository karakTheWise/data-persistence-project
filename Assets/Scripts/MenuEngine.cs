using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;
using TMPro;


public class MenuEngine : MonoBehaviour
{
    public TextMeshProUGUI playerNameEntry;
    static public string playerName;
    private AutosaveScore autoSaveScore;


    //Function to get the player name from the menu
    public void savePlayerName()
    {
        playerName = playerNameEntry.text;
    }

    // When start button is pressed, switch the scene to the game
    public void StartButton()
    {
        //function to load the game
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        
    }

    // When quit button is pressed, Quit the game
    public void QuitButton()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }
}
