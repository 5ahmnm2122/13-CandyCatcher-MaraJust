using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBehavior : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
        Destroy(collision.gameObject);
    }
}
