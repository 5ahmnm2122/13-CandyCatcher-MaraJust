using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Scripts")]
    [Space(7)]
    // needed scripts
    public PlayerData playerData;
    public BasketMovement bm;

    [Header("Canvas Objects")]
    [Space(7)]
    // needed canvas objects
    public Text nameText;
    public Text scoreText;
    public Text timerText;

    [Header("Stats")]
    [Space(7)]
    public float timerTime = 60f;
    public bool timerStillOn = false;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = playerData.playerName;
        playerData.playerScore = 0;

        timerStillOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + playerData.playerScore.ToString();

        if (timerStillOn)
        {
            if (timerTime > 0)
            {
                timerTime -= Time.deltaTime;
                ShowTimeRight(timerTime);
            }
            else
            {
                Debug.Log("Timer out!");
                timerTime = 0;
                timerStillOn = false;

                SceneManager.LoadScene("EndScene");
            }
        }
    }

    void ShowTimeRight(float timer)
    {
        timer += 1;

        float minutes = Mathf.FloorToInt(timer / 60);
        float seconds = Mathf.FloorToInt(timer % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
