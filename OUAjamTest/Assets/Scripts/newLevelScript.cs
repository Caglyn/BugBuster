using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newLevelScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int currentLevel = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(currentLevel + 1);
        }
    }
}