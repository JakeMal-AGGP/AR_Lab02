using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB_Color : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbGameObject;
    public GameObject cube;

    private Color color;

    void Start()
    {
        vbGameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("vb Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        cube.GetComponent<Renderer>().material.SetColor("_Color", color);
        Debug.Log("vb Released");
    }

}
