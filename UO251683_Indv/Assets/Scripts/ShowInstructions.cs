using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInstructions : MonoBehaviour
{

    public GameObject canvasObject;

    private Canvas canvas;

    void Start(){
        canvas = canvasObject.GetComponent<Canvas>();
    }

    void OnMouseDown(){
        canvas.enabled  = !canvas.enabled;
    }
}
