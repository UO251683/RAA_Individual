using UnityEngine;
using System.Collections;

public class GroundTileBasic : MonoBehaviour
{
    GroundSpawner groundSpawner;
    int numberOfGenerations = 1;
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    private void OnTriggerExit(Collider other) 
    {
        numberOfGenerations--;
        if (numberOfGenerations != 0) {
            groundSpawner.SpawnTile();
            Destroy(gameObject, 2);
        }
    }

    void Update()
    {
        
    }

    public GameObject obstaclePrefab;


}
