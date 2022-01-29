using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour
{
    // needed scripts
    [Header("Scripts")]
    [Space(7)]
    public PlayerData playerdata;

    // needed UI objects
    [Header("UI Objects")]
    [Space(7)]
    public Button playButton;
    public InputField nameSpace;
    public string input;

    // called on input in unity
    public void GetNameData ()
    {
        input = nameSpace.text;
        if (input != "")
        {
            playButton.interactable = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        playButton.interactable = false;
        playerdata.playerLost = false;
    }

    public void SaveData ()
    {
        // save name
        playerdata.playerName = input;

        // change scene
        SceneManager.LoadScene("MainScene");
    }
}
