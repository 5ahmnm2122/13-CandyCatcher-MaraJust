using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // needed scripts
    public PlayerData playerData;
    public TimerScript timerscript;
    public basketMovement bm;

    // needed canvas objects
    public Text nameText;
    public Text scoreText;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = playerData.playerName;
        scoreText.text = "Score: " + bm.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
