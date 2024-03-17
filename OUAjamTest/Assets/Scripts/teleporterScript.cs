using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporterScript : MonoBehaviour
{

    public GameObject teleporterPoint;

    //on trigger enter
    private void OnTriggerEnter(Collider other)
    {
        //if other.tag == player
        if (other.tag == "Player")
        {
            //teleport player to teleporterPoint
            other.transform.position = teleporterPoint.transform.position;
        }
    }
}
