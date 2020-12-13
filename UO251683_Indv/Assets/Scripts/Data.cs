using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data : MonoBehaviour
{
    public String tagClicada;
    public String tagActual;


    public void intercambia(String tgActual, String tgObjetivo)
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(tgObjetivo);
        gameObjects[0].transform.position = new Vector3(gameObjects[0].transform.position.x,0.98032f ,gameObjects[0].transform.position.z);
        
        GameObject[] gameObjects2 = GameObject.FindGameObjectsWithTag(tgActual);
        gameObjects2[0].transform.position = new Vector3(gameObjects2[0].transform.position.x,0.7f ,gameObjects2[0].transform.position.z);
    }
}
