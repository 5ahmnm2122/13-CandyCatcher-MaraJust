using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    // needed scripts
    public PlayerData playerdata;

    // needed UI objects
    public Button playButton;
    public InputField nameSpace;
    public string input;

    // called on input in unity
    public void GetNameData ()
    {
        input = nameSpace.text;
        if (input != null)
        {
            playButton.interactable = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playButton.interactable = false;
    }

    public void SaveData ()
    {
        // save name
        playerdata.playerName = input;

        // change scene
        SceneManager.LoadScene("MainScene");
    }
}
