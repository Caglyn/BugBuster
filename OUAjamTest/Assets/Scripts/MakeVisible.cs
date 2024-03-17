using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeVisible : MonoBehaviour, IIntaractable
{
    public GameObject target;

    public void Interact()
    {
        Debug.Log("Interacting with cube");
        ChangeVisible();
    }
    public void ChangeVisible()
    {
        //SetActive is false = true, true = false   
        target.SetActive(!target.activeSelf);
        
    }
}
