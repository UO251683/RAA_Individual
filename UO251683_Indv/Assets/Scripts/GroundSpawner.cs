using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    public GameObject groundTile2;
    public GameObject groundBasic;
    public GameObject groundInit;
    public GameObject groundFin;
    public GameObject groundHole;
    public GameObject groundHole2;
    public GameObject groundWindowL;
    public GameObject groundWindowR;
    Vector3 nextSpawnPoint;

    public void SpawnTile()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnTile2()
    {
        GameObject temp = Instantiate(groundTile2, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnWindowL()
    {
        GameObject temp = Instantiate(groundWindowL, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnWindowR()
    {
        GameObject temp = Instantiate(groundWindowR, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnTileBasic()
    {
        GameObject temp = Instantiate(groundBasic, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnTileInit()
    {
        GameObject temp = Instantiate(groundInit, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    public void SpawnTileFin()
    {
        GameObject temp = Instantiate(groundFin, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnHole()
    {
        GameObject temp = Instantiate(groundHole, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }

    public void SpawnHole2()
    {
        GameObject temp = Instantiate(groundHole2, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;
    }
    
    void Start()
    {
        int numberOfTiles = 40;
        SpawnTileInit();
        for(int i = 1; i<3; i++) {
            SpawnTileBasic();
        }
        for(int i = 3; i<numberOfTiles; i++) {
            int n = Random.Range(0,100);

            if (i % 5 == 0)
            {
                if (n > 40) {
                    SpawnHole();
                }
                else {
                    SpawnHole2();
                }
            }
            else if (i % 4 == 0) {
                SpawnWindowL();
            }
            else if (i % 2 == 0) {
                SpawnWindowR();
            }
            else if (n > 66) {
                SpawnTile();
            }
            else if (n > 33) {
                SpawnTile2();
            }
            else
            {
                SpawnTileBasic();
            }
        }
        SpawnTileFin();
    }
}
