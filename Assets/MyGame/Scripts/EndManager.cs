using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    public PlayerData playerdata;

    public Text playerName;
    public Text playerscore;

    public GameObject win;
    public GameObject lose;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = playerdata.playerName;
        playerscore.text = "Your Score: " + playerdata.playerScore.ToString();

        if (playerdata.playerLost)
        {
            lose.SetActive(true);
            win.SetActive(false);

        } else
        {
            lose.SetActive(false);
            win.SetActive(true);
        }
    }

    public void Restart ()
    {
        SceneManager.LoadScene("IntroScene");
    }

}
