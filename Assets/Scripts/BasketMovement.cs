using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketMovement: MonoBehaviour
{
    [Header("Scripts")]
    [Space(7)]
    public PlayerData playerdata;

    [Header("Stats")]
    [Space(7)]
    public float basketSpeed = 10f;
    public int lifes = 3;

    [Header("Lifes")]
    [Space(7)]
    public GameObject ThreeLifesLeft;
    public GameObject TwoLifesLeft;
    public GameObject OneLifesLeft;


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
    public void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.name.ToString() + "With Basket Collided");

        if (collision.gameObject.tag == "GoodCandy")
        {
            playerdata.playerScore += 1;
            Debug.Log(playerdata.playerScore);



            Destroy(collision.gameObject);

        } else if (collision.gameObject.tag == "BadCandy")
        {
            // manage lifes
            if (lifes > 0)
            {
                lifes -= 1;
                if (lifes == 2)
                {
                    ThreeLifesLeft.SetActive(false);
                }
                else if (lifes == 1)
                {
                    TwoLifesLeft.SetActive(false);
                } else
                {
                    ThreeLifesLeft.SetActive(false);
                    TwoLifesLeft.SetActive(false);
                    OneLifesLeft.SetActive(false);

                    Debug.Log("Lost");
                    playerdata.playerLost = true;

                    SceneManager.LoadScene("EndScene");
                }
            }
            Destroy(collision.gameObject);
        }
    }
}
