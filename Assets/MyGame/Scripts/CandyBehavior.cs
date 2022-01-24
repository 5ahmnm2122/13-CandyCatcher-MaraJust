using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyBehavior : MonoBehaviour
{
    public float candySpeed = 4f;


    private void Update ()
    {
        Vector3 movement = new Vector3 (0,-1,0);
        transform.Translate(movement * candySpeed * Time.deltaTime);
    }


}
