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

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
        {
            if (hit.transform.tag == "Painting")
            {
                pointer.GetComponent<Image>().color = green;
            }
            else
            {
                pointer.GetComponent<Image>().color = white;
            }
            if (Input.GetButtonDown("Fire1"))
            {
                Debug.Log(hit.transform.name);
            }
        }
    }
}
