using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InizializePotions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject pocionRoja = GameObject.FindGameObjectWithTag("pocion_objetivo_roja");
        GameObject pocionAzul = GameObject.FindGameObjectWithTag("pocion_objetivo_azul");
        GameObject pocionVerde = GameObject.FindGameObjectWithTag("pocion_objetivo_verde");
        GameObject pocionAmarilla = GameObject.FindGameObjectWithTag("pocion_objetivo_amarilla");
        GameObject pocionNaranja = GameObject.FindGameObjectWithTag("pocion_objetivo_naranja");
        GameObject pocionMorada = GameObject.FindGameObjectWithTag("pocion_objetivo_morada");
        GameObject pocionCyan = GameObject.FindGameObjectWithTag("pocion_objetivo_cyan");
        GameObject pocionBlanca = GameObject.FindGameObjectWithTag("pocion_objetivo_blanca");
        GameObject pocionNegra = GameObject.FindGameObjectWithTag("pocion_objetivo_negra");

        pocionRoja.transform.position = new Vector3(pocionRoja.transform.position.x, pocionRoja.transform.position.y - 2f, pocionRoja.transform.position.z);
        pocionAzul.transform.position = new Vector3(pocionAzul.transform.position.x, pocionAzul.transform.position.y - 2f, pocionAzul.transform.position.z);
        pocionVerde.transform.position = new Vector3(pocionVerde.transform.position.x, pocionVerde.transform.position.y - 2f, pocionVerde.transform.position.z);
        pocionAmarilla.transform.position = new Vector3(pocionAmarilla.transform.position.x, pocionAmarilla.transform.position.y - 2f, pocionAmarilla.transform.position.z);
        pocionNaranja.transform.position = new Vector3(pocionNaranja.transform.position.x, pocionNaranja.transform.position.y - 2f, pocionNaranja.transform.position.z);
        pocionMorada.transform.position = new Vector3(pocionMorada.transform.position.x, pocionMorada.transform.position.y - 2f, pocionMorada.transform.position.z);
        pocionBlanca.transform.position = new Vector3(pocionBlanca.transform.position.x, pocionBlanca.transform.position.y - 2f, pocionBlanca.transform.position.z);
        pocionNegra.transform.position = new Vector3(pocionNegra.transform.position.x, pocionNegra.transform.position.y - 2f, pocionNegra.transform.position.z);
        pocionCyan.transform.position = new Vector3(pocionCyan.transform.position.x, pocionCyan.transform.position.y - 2f, pocionCyan.transform.position.z);

        print("Pociones inicializadas");
    }
}
