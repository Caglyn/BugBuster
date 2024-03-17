using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunsonu : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Oyun bitti");
            Application.Quit();
        }
    }
}
