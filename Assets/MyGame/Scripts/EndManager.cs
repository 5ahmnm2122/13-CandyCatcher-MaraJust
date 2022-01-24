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
    public Text playerHighscore;

    public GameObject win;
    public GameObject lose;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = playerdata.playerName;
        playerscore.text = "Your Score: " + playerdata.playerScore.ToString();
        playerHighscore.text = "Current Highscore: " + playerdata.currentHighscore.ToString();

        if (playerdata.playerLost)
        {
            lose.SetActive(true);
            win.SetActive(false);

        }
        else
        {
            lose.SetActive(false);
            win.SetActive(true);
        }

        if (playerdata.playerScore > playerdata.currentHighscore)
        {
            playerdata.playerScore = playerdata.currentHighscore;
            Debug.Log("New HighScore!");
        }
        else
        {
            playerdata.currentHighscore = playerdata.playerScore;
        }
    }

    public void Restart ()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void Quit()
    {
        Application.Quit();
    }

}
