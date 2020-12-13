
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public Transform target;
    bool alive = true;
    
    public float time = 0;

    private int vida = 100;
    
    bool estaSaltando = false;
    
    public int puntuación = 0;

    public float speed = 3;
    public Rigidbody rb;
    public static GvrControllerButton button;

    float horizontalInput;
    // Mayor velocidad en horizontal
    public float horizontalMultiplier = 2;

    public void Start () {
        // Evita cambiar la rotación del objeto continuamente.
        if (GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().freezeRotation = true;
    }
    
    void FixedUpdate() 
    {
        time += Time.deltaTime; //Variable que guarda el tiempo de juego
        if  (!alive) {
            return;
        }
        
        // Movimiento hacia adelante automatico
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;

        // Movimiento lateral (A y D)
        Vector3 HorizontalMove = transform.right * horizontalInput;
        
        // Salto
        Vector3 salto = new Vector3(0, 0, 0);
        
        //Si pulsa el boton y no está saltando (es decir, está en el suelo)
        if (Input.GetButtonDown("Fire1") && estaSaltando == false)
        {
            salto = new Vector3(1f, 3, 0);
            estaSaltando = true; //Y está saltando
        }
        
        rb.MovePosition(rb.position + forwardMove + HorizontalMove + salto);

        if (Input.GetKeyDown("r")) { //Si presiona R
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Reinicia el nivel
        }

       
    }

    void Update()
    {
        float horizontal = Camera.main.transform.eulerAngles.z;
        if (horizontal >= 20 && horizontal <= 80)
        {
            horizontalInput = -0.1f;
        }
        
        else if (horizontal <= 340 && horizontal >= 280)
        {
            horizontalInput = +0.1f;
        }

        else
        {
            horizontalInput = 0.0f;
        }

        print(horizontalInput);

        if(transform.position.y < -50.0f) {
            Die();
        }
    }

    public void Die() {
        alive = false;
        Invoke("Restart", 2);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    
    public void OnCollisionEnter(Collision collision)
    {
        GameObject other = collision.gameObject;
        
        //Si encuentra un item
        if (other.CompareTag("item"))
        {
            other.SetActive(false); //Lo consume
            puntuación += puntuación + 10; //Y aumenta la puntuación
            print("Puntuación actual: " + puntuación);
        }
        
        //Si esta en el suelo
        if (other.CompareTag("suelo"))
        {
            estaSaltando = false; //No está saltando
        }
        
        //(NO USADO AUN)
        //Si encuentra un obstáculo
        if (other.CompareTag("obstaculo"))
        {
            //Pierde vida
            vida -= 20;
            print("Vida actual: " + vida); 
        }
        
        //Si encuentra el final
        if(other.CompareTag("fin")) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (other.CompareTag("terminaTroll"))
        {
            SceneManager.LoadScene("PotionsScene");
        }
        
        if (other.CompareTag("terminaPociones"))
        {
            SceneManager.LoadScene("Quidditch");
        }
        
        if (other.CompareTag("terminaTodo"))
        {
            SceneManager.LoadScene("MenuFinScene");
        }
        
    }

    public static float ClampAngle (float angle, float min, float max) {
        if (angle < -360.0f)
            angle += 360.0f;
        if (angle > 360.0f)
            angle -= 360.0f;
        return Mathf.Clamp (angle, min, max);
    }
}
