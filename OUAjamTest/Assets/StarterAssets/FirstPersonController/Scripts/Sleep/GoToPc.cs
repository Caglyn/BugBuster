using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoToPc : MonoBehaviour
{
    public static GoToPc Instance {get; set;}

    public GameObject go_To_Sleep_UI;
    public bool onTarget;
    
    Text sleep_text;

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

    // Start is called before the first frame update
    void Start()
    {
        onTarget = false;

        sleep_text = go_To_Sleep_UI.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            var selectionTransform = hit.transform;
            InteractablePc interactable = selectionTransform.GetComponent<InteractablePc>();

            if(interactable && interactable.playerInRange)
            {
                onTarget = true;

                sleep_text.text = "Bilgisayara gitmek için E tuşuna basın";
                go_To_Sleep_UI.SetActive(true);
            }
            else
            {
                onTarget = false;
                go_To_Sleep_UI.SetActive(false);
            }
        }
        else
        {
            onTarget = false;
            go_To_Sleep_UI.SetActive(false);
        }
    }
}
