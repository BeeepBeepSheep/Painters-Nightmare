using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LookingAt : MonoBehaviour
{
    public Camera cam;

    public GameObject pointer;
    public Color green;
    public Color white;
    public Color blue;

    private Transform nextLocation;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            if (hit.transform.tag == "Painting")
            {
                pointer.GetComponent<Image>().color = green;
            }
            if (hit.transform.tag == "MoveSpot")
            {
                pointer.GetComponent<Image>().color = blue;
                if(Input.GetButtonDown("Fire1"))
                {
                    //Debug.Log("move");
                    nextLocation = hit.transform.GetChild(0);
                    transform.position = nextLocation.position;
                }
            }
            if (hit.transform.tag != "MoveSpot" && hit.transform.tag != "Painting")
            {
                pointer.GetComponent<Image>().color = white;
            }
        }
    }
}
