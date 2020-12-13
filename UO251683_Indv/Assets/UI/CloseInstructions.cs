using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInstructions : MonoBehaviour
{
    public GameObject canvasObject;

    private Canvas canvas;

    void Start(){
        canvas = canvasObject.GetComponent<Canvas>();
    }

    void OnMouseDown(){
        canvas.enabled  = false;
    }
}
