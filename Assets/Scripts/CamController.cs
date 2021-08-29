using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] private float sensX = 100f;
    [SerializeField] private float sensY = 100f;
    //public bool invertX = false;
    //public bool invertY = false;
    //public GameObject tickX;
    //public GameObject tickY;

    [SerializeField] Transform cam;
    [SerializeField] Transform orientation;

    float mouseX;
    float mouseY;

    public float multiplier = 0.01f;

    float xRotation;
    float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        Look();
    }
    private void Look()
    {
        mouseX = Input.GetAxisRaw("Mouse X");
        mouseY = Input.GetAxisRaw("Mouse Y");

        //if (invertX)
        //{
        //    mouseX = -mouseX;
        //}
        //if (invertY)
        //{
        //    mouseY = -mouseY;
        //}

        yRotation += mouseX * sensX * multiplier;
        xRotation -= mouseY * sensY * multiplier;

        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cam.transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.transform.rotation = Quaternion.Euler(0, yRotation, 0);
    }
    //public void AjustSens_Both(float newSens)
    //{
    //    sensX = newSens;
    //    sensY = newSens;
    //}
    //public void Invert_X_Axis()
    //{
    //    if (invertX)
    //    {
    //        invertX = false;
    //        tickX.SetActive(false);
    //    }
    //    else
    //    {
    //        invertX = true;
    //        tickX.SetActive(true);
    //    }
    //}
    //public void Invert_Y_Axis()
    //{
    //    Debug.Log("InvertedX");
    //    if (invertY)
    //    {
    //        invertY = false;
    //        tickY.SetActive(false);
    //    }
    //    else
    //    {
    //        invertY = true;
    //        tickY.SetActive(true);
    //    }
    //}
}
