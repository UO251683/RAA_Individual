using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractablePocionRoja : AbstractInteractable
{
    private String pocionActual;

    private String pocionResultado;

    private String pocionClicada;

    private bool clicada;
    
    
    // Si vamos a usar Start en la subclase, llamamos primero a la super, para que añada las llamadas a los métodos en el EventTrigger
    protected override void Start()
    { 
        base.Start();
        pocionActual = "pocion_objetivo";
        pocionResultado = "";
        pocionClicada = "pocion_objetivo_roja";
        clicada = false;
    }
    public void Update()
    {
        if (clicada)
        {
            if (pocionActual == "pocion_objetivo")
            {
                GameObject pocActual = GameObject.FindGameObjectWithTag(pocionActual);
                pocActual.transform.position = new Vector3(pocActual.transform.position.x, pocActual.transform.position.y - 2f, pocActual.transform.position.z);

                GameObject pocClicada = GameObject.FindGameObjectWithTag(pocionClicada);
                pocClicada.transform.position = new Vector3(pocClicada.transform.position.x, pocClicada.transform.position.y + 2f, pocClicada.transform.position.z);
            }
            
            else if (pocionActual == "pocion_objetivo_roja")
            {
            }
            
            else if (pocionActual == "pocion_objetivo_verde")
            {
                GameObject pocActual = GameObject.FindGameObjectWithTag(pocionActual);
                pocActual.transform.position = new Vector3(pocActual.transform.position.x, pocActual.transform.position.y - 2f, pocActual.transform.position.z);

                GameObject pocClicada = GameObject.FindGameObjectWithTag("pocion_objetivo_amarilla");
                pocClicada.transform.position = new Vector3(pocClicada.transform.position.x, pocClicada.transform.position.y + 2f, pocClicada.transform.position.z);
            }
            
            else if (pocionActual == "pocion_objetivo_azul")
            {
                GameObject pocActual = GameObject.FindGameObjectWithTag(pocionActual);
                pocActual.transform.position = new Vector3(pocActual.transform.position.x, pocActual.transform.position.y - 2f, pocActual.transform.position.z);

                GameObject pocClicada = GameObject.FindGameObjectWithTag("pocion_objetivo_morada");
                pocClicada.transform.position = new Vector3(pocClicada.transform.position.x, pocClicada.transform.position.y + 2f, pocClicada.transform.position.z);
            }
            
            else if (pocionActual == "pocion_objetivo_amarilla")
            {
                GameObject pocActual = GameObject.FindGameObjectWithTag(pocionActual);
                pocActual.transform.position = new Vector3(pocActual.transform.position.x, pocActual.transform.position.y - 2f, pocActual.transform.position.z);

                GameObject pocClicada = GameObject.FindGameObjectWithTag("pocion_objetivo_naranja");
                pocClicada.transform.position = new Vector3(pocClicada.transform.position.x, pocClicada.transform.position.y + 2f, pocClicada.transform.position.z);
            }
            
            else if (pocionActual == "pocion_objetivo_cyan")
            {
                GameObject pocActual = GameObject.FindGameObjectWithTag(pocionActual);
                pocActual.transform.position = new Vector3(pocActual.transform.position.x, pocActual.transform.position.y - 2f, pocActual.transform.position.z);

                GameObject pocClicada = GameObject.FindGameObjectWithTag("pocion_objetivo_morada");
                pocClicada.transform.position = new Vector3(pocClicada.transform.position.x, pocClicada.transform.position.y + 2f, pocClicada.transform.position.z);
            }
            
            else if (pocionActual == "pocion_objetivo_naranja")
            {
                GameObject pocActual = GameObject.FindGameObjectWithTag(pocionActual);
                pocActual.transform.position = new Vector3(pocActual.transform.position.x, pocActual.transform.position.y - 2f, pocActual.transform.position.z);

                GameObject pocClicada = GameObject.FindGameObjectWithTag("pocion_objetivo_roja");
                pocClicada.transform.position = new Vector3(pocClicada.transform.position.x, pocClicada.transform.position.y + 2f, pocClicada.transform.position.z);
            }
            
            else if (pocionActual == "pocion_objetivo_morada")
            {
                GameObject pocActual = GameObject.FindGameObjectWithTag(pocionActual);
                pocActual.transform.position = new Vector3(pocActual.transform.position.x, pocActual.transform.position.y - 2f, pocActual.transform.position.z);

                GameObject pocClicada = GameObject.FindGameObjectWithTag("pocion_objetivo_roja");
                pocClicada.transform.position = new Vector3(pocClicada.transform.position.x, pocClicada.transform.position.y + 2f, pocClicada.transform.position.z);
            }
            
            else if (pocionActual == "pocion_objetivo_blanca")
            {
                GameObject pocActual = GameObject.FindGameObjectWithTag(pocionActual);
                pocActual.transform.position = new Vector3(pocActual.transform.position.x, pocActual.transform.position.y - 2f, pocActual.transform.position.z);

                GameObject pocClicada = GameObject.FindGameObjectWithTag("pocion_objetivo_roja");
                pocClicada.transform.position = new Vector3(pocClicada.transform.position.x, pocClicada.transform.position.y + 2f, pocClicada.transform.position.z);
            }
            
            else if (pocionActual == "pocion_objetivo_negra")
            {
            }
            
            clicada = false;
        }
    }

    public override void OnPointerClick()
    {
        actualizaPocionActual();
        clicada = true;
    }
    
    public void actualizaPocionActual()
    {
        String tagActual = "";
        if (GameObject.FindGameObjectWithTag("pocion_objetivo").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo";
        }
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_roja").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_roja";
        }
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_azul").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_azul";
        }
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_verde").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_verde";
        }
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_amarilla").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_amarilla";
        }
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_naranja").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_naranja";
        }
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_cyan").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_cyan";
        }
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_morada").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_morada";
        }
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_blanca").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_blanca";
        }
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_negra").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_negra";
        }

        else
        {
            tagActual = "invalida";
        }
        print(tagActual);
        pocionActual = tagActual;
    }
}
