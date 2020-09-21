using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB_RotateX : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbGameObject;
    public GameObject cube;
    public bool isRotating;

    private Color color;

    void Start()
    {
        vbGameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        isRotating = false;

    }

    private void Update()
    {
        if(isRotating)
        {
            cube.transform.Rotate(25 * Time.deltaTime, 0, 0);
        }
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("vb Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        if(isRotating)
        {
            isRotating = false;
        }
        else
        {
            isRotating = true;
        }
        Debug.Log("vb Released");
    }
}
