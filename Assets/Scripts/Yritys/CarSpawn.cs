using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{
    [SerializeField]
    private CarMovement prefab;
    // ObjectPooler objectPooler;
    private Pool pool;
    public bool invoke = true;
    /* public Transform[] spawnLocations;
     public GameObject[] whatToSpawnPrefab;
     public GameObject[] whatToSpawnClone;
     */

    private void Start()
    {
       
        pool = Pool.GetPool(prefab);
        // objectPooler = ObjectPooler.Instance;
        SpawnCar();

            InvokeRepeating("SpawnCar", 2.2f, 2.2f);

        }
    private void Update()
    {
        if (invoke == false)
        {
            CancelInvoke("SpawnCar");
        }
    }
    private void SpawnCar()
        {
        
        var car = pool.Get(transform.position, Quaternion.identity) as CarMovement;
        
        // makes clones of the car.
        // objectPooler.SpawnFromPool("Car", transform.position, Quaternion.identity);

        // whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
        // whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLocations[1].transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
        //whatToSpawnClone[2] = Instantiate(whatToSpawnPrefab[2], spawnLocations[2].transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;
        //whatToSpawnClone[3] = Instantiate(whatToSpawnPrefab[3], spawnLocations[3].transform.position, Quaternion.Euler(0, 90, 0)) as GameObject;


    }
    }


