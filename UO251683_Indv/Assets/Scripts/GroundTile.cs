using UnityEngine;
using System.Collections;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    int numberOfGenerations = 1;
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
        SpawnBeans();
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

    void SpawnObstacle()
    {
        int obstacleSpawnIndex1 = Random.Range(2, 4);
        int obstacleSpawnIndex2 = Random.Range(5, 7);

        int obstacleSpawnIndex3 = Random.Range(1, 3);

        if(obstacleSpawnIndex3 == 1) {
            obstacleSpawnIndex3 = 2;
            if(obstacleSpawnIndex1 == 2){
                obstacleSpawnIndex3 = 3;
            }
        } else if(obstacleSpawnIndex3 == 2) {
            obstacleSpawnIndex3 = 4;
        } else {
            obstacleSpawnIndex3 = 5;
            if(obstacleSpawnIndex1 == 5){
                obstacleSpawnIndex3 = 6;
            }
        }

        Transform spawnPoint1 = transform.GetChild(obstacleSpawnIndex1).transform;
        Transform spawnPoint2 = transform.GetChild(obstacleSpawnIndex2).transform;
        Transform spawnPoint3 = transform.GetChild(obstacleSpawnIndex3).transform;

        Instantiate(obstaclePrefab, spawnPoint1.position, Quaternion.identity, transform);
        Instantiate(obstaclePrefab, spawnPoint2.position, Quaternion.identity, transform);
        Instantiate(obstaclePrefab, spawnPoint3.position, Quaternion.identity, transform);
    }

    public GameObject beanPrefab;
    public GameObject beanVPrefab;
    public GameObject beanAPrefab;

    void SpawnBeans() {
        int beansToSpawn = 2;
        for(int i = 0; i<beansToSpawn; i++) {
            GameObject temp = Instantiate(beanPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
        for(int i = 0; i<beansToSpawn; i++) {
            GameObject temp = Instantiate(beanAPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
        for(int i = 0; i<beansToSpawn; i++) {
            GameObject temp = Instantiate(beanVPrefab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }

    Vector3 GetRandomPointInCollider(Collider collider) {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z));

        // Precaución
        if(point != collider.ClosestPoint(point)) {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }

    
}
