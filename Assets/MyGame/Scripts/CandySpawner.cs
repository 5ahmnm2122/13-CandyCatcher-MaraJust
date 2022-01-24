using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] candy;

    public float xMin = -7.48f;
    public float xMax = 7.5f;

    public float posY = 5;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Candy());
    }
    
    // spawn Candy
    IEnumerator Candy ()
    {
        while (true)
        {
            Vector3 candyPos = new Vector3(Random.Range(xMin, xMax), posY, gameObject.transform.position.z);
            GameObject.Instantiate(candy[Random.Range(0, candy.Length)], candyPos, Quaternion.identity);

            yield return new WaitForSeconds(Random.Range(0f, 2f));
        }
    }
}
