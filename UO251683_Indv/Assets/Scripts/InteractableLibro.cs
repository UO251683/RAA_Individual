using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableLibro : AbstractInteractable
{
    private bool clicada;

    public Text texto;
    
     // Si vamos a usar Start en la subclase, llamamos primero a la super, para que añada las llamadas a los métodos en el EventTrigger
     protected override void Start()
     { 
         base.Start();
         clicada = false;
     }
    public void Update()
    {
        if (clicada)
        {
            Invoke("DisableText", 4f);
            
            clicada = false;
        }
    }
    
    public void DisableText()
    { 
        texto.enabled = false; 
    }    

    public override void OnPointerClick()
    {
        clicada = true;
    }

    
}
