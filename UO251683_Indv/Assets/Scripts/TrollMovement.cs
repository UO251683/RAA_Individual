
using UnityEngine;

public class TrollMovement : MonoBehaviour
{

    public Transform target;
    bool alive = true;
    

    public float speed = 3;
    public Rigidbody rb;

    public void Start () {
        // Evita cambiar la rotación del objeto continuamente.
        if (GetComponent<Rigidbody>())
            GetComponent<Rigidbody>().freezeRotation = true;
    }
    
    void FixedUpdate() 
    {
        if  (!alive) {
            return;
        }
        
        // Movimiento hacia adelante automatico
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;

        rb.MovePosition(rb.position + forwardMove);

    }
}
