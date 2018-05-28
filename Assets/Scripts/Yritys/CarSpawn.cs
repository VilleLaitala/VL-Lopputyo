using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawn : MonoBehaviour
{

    public float spawnCarRate;
    public float spawnCarRepeat;

    [SerializeField]
    private CarMovement prefab;
    private Pool pool;
    public bool invoke = true;
    

    private void Start()
    {
       
        pool = Pool.GetPool(prefab);
        SpawnCar();

            InvokeRepeating("SpawnCar", spawnCarRate, spawnCarRepeat);

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
        
        var car = pool.Get(transform.position, transform.rotation) as CarMovement;
        

    }
    }


