using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VB_ScaleDown : MonoBehaviour, IVirtualButtonEventHandler
{
    public GameObject vbGameObject;
    public GameObject cube;
    public float minScale;
    public float scaleAmount;

    private Color color;

    void Start()
    {
        vbGameObject.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        minScale = 1;
        scaleAmount = -0.1f;

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("vb Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

        cube.transform.localScale += new Vector3(scaleAmount, scaleAmount, scaleAmount);
        Debug.Log("vb Released");
    }
}
