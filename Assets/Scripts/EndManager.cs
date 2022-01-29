using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndManager : MonoBehaviour
{
    [Header("Scripts")]
    [Space(7)]
    public PlayerData playerdata;

    [Header("UI Objects")]
    [Space(7)]
    public Text playerName;
    public Text playerscore;
    public Text playerHighscore;

    [Header("Win or Lose")]
    [Space(7)]
    public GameObject win;
    public GameObject lose;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = playerdata.playerName;
        playerscore.text = "Your Score: " + playerdata.playerScore.ToString();
        playerHighscore.text = "Current Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();

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


        if (playerdata.playerScore > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", playerdata.playerScore);
            playerHighscore.text = "Current Highscore: " + playerdata.playerScore.ToString();
        }
    }

    private void Update()
    {
        playerHighscore.text = "Current Highscore: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void Restart ()
    {
        SceneManager.LoadScene("IntroScene");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Reset ()
    {
        PlayerPrefs.DeleteAll();
    }
}
