using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCode : MonoBehaviour, IIntaractable
{
    public GameObject cube;

    public int size = 5;

    public void Interact()
    {
        Debug.Log("Interacting with cube");
        ChangeSize(size);
    }
    
    public void ChangeSize(float size)
    {
        cube.transform.localScale = new Vector3(size, size, size);
    }
}
