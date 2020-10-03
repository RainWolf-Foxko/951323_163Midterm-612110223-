using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObjectsSpawnManager : MonoBehaviour
{
    [SerializeField]
    GameObject[] _itemToBeSpawn;

    [SerializeField]
    GameObject[] _obstaclesToBeSpawn;

    // Start is called before the first frame update
    void Start()
    {   
        Invoke("SpawnObstacle", 2.0f);
        Invoke("SpawnItem", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacle()
    {
         int ObsIdx = Random.Range(0, _obstaclesToBeSpawn.Length);
        GameObject go = Instantiate(_obstaclesToBeSpawn[ObsIdx],
            new Vector3(Random.Range(-2f, 2f), 10, Random.Range(0, 40f)), Quaternion.identity);
        Destroy(go, 10);

        float nextSpawnTime = Random.Range(0.2f, 1);
        Invoke("SpawnObstacle", nextSpawnTime);
    }
    void SpawnItem(){
        int ItemIdx = Random.Range(0, _itemToBeSpawn.Length);
        GameObject go = Instantiate(_itemToBeSpawn[ItemIdx],
            new Vector3(Random.Range(-2f, 2f), 10, Random.Range(0, 40f)), Quaternion.identity);
        Destroy(go, 10);

        float nextSpawnTime = Random.Range(0.2f, 1);
        Invoke("SpawnItem", nextSpawnTime);
    }
}
