
using UnityEngine;

public class Bean : MonoBehaviour
{

    public float turnSpeed = 90f;
    public AudioClip Sonido;


    private void OnTriggerEnter(Collider other) 
    {
        
        if(other.gameObject.GetComponent<Obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }

        if(other.gameObject.name != "Player") {
            return;
        }
        
        GameManager.inst.IncrementScore();
        Vector3 position = transform.position;
        AudioSource.PlayClipAtPoint(Sonido, position); 
        Destroy(gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(turnSpeed * Time.deltaTime, turnSpeed * Time.deltaTime, turnSpeed * Time.deltaTime);
    }
}
