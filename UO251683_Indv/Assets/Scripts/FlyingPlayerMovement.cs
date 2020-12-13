using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyingPlayerMovement : MonoBehaviour
{

    public Transform target;
    bool alive = true;
    
    public float time = 0;

    private int vida = 100;
    
    bool estaSaltando = false;
    
    public int puntuación = 0;

    public GvrReticlePointer gvr;

    public float speed = 3;
    public Rigidbody rb;

    private float sensibility = 10f;
    
    private float horizontalInput;


    private float verticalInput;
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
        
        // Movimiento lateral
        Vector3 HorizontalMove = transform.right * horizontalInput;
        
        // Movimiento vertical
        Vector3 VerticalMove = transform.up * verticalInput;
        
        rb.MovePosition(rb.position + forwardMove + HorizontalMove + VerticalMove);

        if (Input.GetKeyDown("r")) { //Si presiona R
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); //Reinicia el nivel
        }
    }

    void Update()
    {
        void Update()
        {
            float horizontal = Camera.main.transform.eulerAngles.z;
            float vertical = Camera.main.transform.eulerAngles.y;
            if (horizontal >= 20 && horizontal <= 80)
            {
                horizontalInput = -0.1f;
            }
        
            else if (horizontal <= 340 && horizontal >= 280)
            {
                horizontalInput = +0.1f;
            }
            
            else if (vertical >= 20)
            {
                verticalInput = -0.1f;
            }
            
            else if (vertical <= 340 && vertical >= 280)
            {
                verticalInput = +0.1f;
            }

            else
            {
                verticalInput = 0.0f;
                horizontalInput = 0.0f;
            }

            print( "HORIZONTAL: " + horizontalInput);
            print("VERTICAL: " + verticalInput);

            if(transform.position.y < -50.0f) {
                Die();
            }
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

        //Si encuentra el final
        if(other.CompareTag("fin")) 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
