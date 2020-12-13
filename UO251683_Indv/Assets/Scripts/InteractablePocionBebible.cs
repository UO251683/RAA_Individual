using System;
using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class InteractablePocionBebible : AbstractInteractable
{
    private String pocionActual;

    private String pocionResultado;

    private String pocionClicada;

    private bool clicada;
    
    public AudioClip Sonido;
    
    public AudioClip Correcto;

    public AudioClip Fallo;


    private bool naranjaBebida = false;

    private bool moradaBebida = false;

    private bool cyanBebida = false;

    private int numFallos = 0;

    
     // Si vamos a usar Start en la subclase, llamamos primero a la super, para que añada las llamadas a los métodos en el EventTrigger
     protected override void Start()
     { 
         base.Start();
         pocionActual = "pocion_objetivo";
         pocionResultado = "";
         clicada = false;
         Text textoObjetivo  = GameObject.FindGameObjectWithTag("pocion_objetivo_text").GetComponent<Text>(); 
         textoObjetivo.text = "Objetivos: 1.- Cyan; 2.- Morada; 3.- Naranja";
     }
    public void Update()
    {
        if (clicada)
        {
            if (pocionActual == "pocion_objetivo")
            {
                
            }
            
            else
            {
                GameObject pocActual = GameObject.FindGameObjectWithTag(pocionActual);
                pocActual.transform.position = new Vector3(pocActual.transform.position.x, pocActual.transform.position.y - 2f, pocActual.transform.position.z);
                Vector3 position = transform.position;

                if (pocionActual == "pocion_objetivo_naranja" && moradaBebida && cyanBebida && !naranjaBebida)
                {
                    AudioSource.PlayClipAtPoint(Correcto, position);
                    naranjaBebida = true;
                }
                
                else if (pocionActual == "pocion_objetivo_morada" && cyanBebida && !moradaBebida)
                {
                    AudioSource.PlayClipAtPoint(Correcto, position);
                    moradaBebida = true;
                }
                
                else if (pocionActual == "pocion_objetivo_cyan" && !cyanBebida)
                {
                    AudioSource.PlayClipAtPoint(Correcto, position);
                    cyanBebida = true;
                }

                else
                {
                    numFallos++;
                    AudioSource.PlayClipAtPoint(Fallo, position);
                    if (numFallos >= 3)
                    {
                        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                    }
                }

                GameObject pocClicada = GameObject.FindGameObjectWithTag("pocion_objetivo");
                pocClicada.transform.position = new Vector3(pocClicada.transform.position.x, pocClicada.transform.position.y + 2f, pocClicada.transform.position.z);
                
                AudioSource.PlayClipAtPoint(Sonido, position);

                if (naranjaBebida && moradaBebida && cyanBebida)
                {
                    SceneManager.LoadScene("PotionsScene");
                }
                
                clicada = false;
            }
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
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_cyan").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_cyan";
        }
        
        else if (GameObject.FindGameObjectWithTag("pocion_objetivo_naranja").transform.position.y > -1)
        {
            tagActual = "pocion_objetivo_naranja";
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
