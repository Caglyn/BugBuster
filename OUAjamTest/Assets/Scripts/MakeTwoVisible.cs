using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeTwoCisi : MonoBehaviour, IIntaractable
{

    public GameObject[] targets;

    public void Interact()
    {
        Debug.Log("Interacting with cube");
        ChangeVisible();
    }
    public void ChangeVisible()
    {
        foreach (GameObject target in targets)
        {
            target.SetActive(!target.activeSelf);
        }
    }
}
