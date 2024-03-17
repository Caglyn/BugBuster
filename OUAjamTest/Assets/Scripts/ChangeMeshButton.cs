using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMeshButton : MonoBehaviour, IIntaractable
{
    public GameObject target;

    public Mesh newMesh;

    public void Interact()
    {
        Debug.Log("Interacting with cube");
        ChangeMesh();
    }
    public void ChangeMesh()
    {
        target.GetComponent<MeshFilter>().mesh = newMesh;
    }
}
