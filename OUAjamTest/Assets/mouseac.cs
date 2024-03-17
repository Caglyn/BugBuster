using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseac : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        CursorLockMode lockMode = CursorLockMode.Locked;
        Cursor.lockState = lockMode;   
    }
}
