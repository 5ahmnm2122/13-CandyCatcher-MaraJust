using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{

    public float timerTime = 60f;
    public bool timerStillOn = false;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        timerStillOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStillOn)
        {
            if (timerTime > 0)
            {
                timerTime -= Time.deltaTime;
                // Debug.Log(timerTime.ToString());
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
