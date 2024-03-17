using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    public GameObject ghost;
    public GameObject placed;
    public float maxDistance = 10f;
    public bool isPlacementMode = false;

    public static PlaceObject Instance {get; set;}

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlacementMode)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                ghost.transform.position = hit.point;
                
                float distance = Vector3.Distance(transform.position, ghost.transform.position);

                if(Input.GetMouseButtonDown(0) && distance <= maxDistance)
                {
                    Instantiate(placed, ghost.transform.position, ghost.transform.rotation);
                    isPlacementMode = false;
                    //Destroy(ghost);
                    ghost.SetActive(false);
                    //placed.GetComponent<InteractableObject>().isPlaced = true;
                }
                else if(Input.GetMouseButtonDown(1))
                {
                    isPlacementMode = false;
                    ghost.SetActive(false);
                }
            }
        }
    }

    public void TogglePlacementMode(GameObject itemToPlace)
    {
        isPlacementMode = !isPlacementMode;
        ghost = Resources.Load<GameObject>(itemToPlace.tag + "ModelGhost");
        placed = Resources.Load<GameObject>(itemToPlace.tag + "Model");

        if(isPlacementMode)
        {
            ghost = Instantiate(ghost, Vector3.zero, Quaternion.identity);
            ghost.SetActive(true);
        }
        
    }
}
