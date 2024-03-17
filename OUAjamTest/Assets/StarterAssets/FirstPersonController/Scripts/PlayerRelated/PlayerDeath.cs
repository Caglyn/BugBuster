using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Lava"))
        {
            Debug.Log("triggerd2");
            transform.position = new Vector3(12, 13, 50);
        }
    }
}
