using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class basketMovement: MonoBehaviour
{
    public PlayerData playerdata;

    public float basketSpeed = 10f;
    //public Rigidbody2D basketRB;

    public int score;
    public int lifes = 3;

    public GameObject ThreeLifesLeft;
    public GameObject TwoLifesLeft;
    public GameObject OneLifesLeft;

    // Start is called before the first frame update
    void Start()
    {
        //basketRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement with left and right arrow keys
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0f,0f) * Time.deltaTime * basketSpeed;

        // Movement with Mouse position
        // Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // mousePosition.x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x; 
        // mousePosition.y = transform.position.y;
        // transform.position = Vector3.MoveTowards(transform.position, mousePosition, basketSpeed * Time.deltaTime);

  
    }

    // count score
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("goodCandy"))
        {
            score += 1;
            Debug.Log(score);

        } else if (collision.gameObject.CompareTag("badCandy"))
        {
            if (lifes > 0)
            {
                lifes -= 1;
                if (lifes == 2)
                {
                    ThreeLifesLeft.SetActive(false);
                }
                else if (lifes == 1)
                {
                    ThreeLifesLeft.SetActive(false);
                    TwoLifesLeft.SetActive(false);
                }

            }
            else
            {
                ThreeLifesLeft.SetActive(false);
                TwoLifesLeft.SetActive(false);
                OneLifesLeft.SetActive(false);

                Debug.Log("Lost");
                playerdata.playerLost = true;

                SceneManager.LoadScene("EndScene");
            }
        }
    }
}
