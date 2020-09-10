using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject target;

    public static int targetAmount;
    public int distance;

    void Start()
    {
        targetAmount = 0;
    }
 
    // Update is called once per frame
    void Update()
    {
        if (targetAmount <= 15)
        {
          SpawnTarget();  
        }
    }

    void SpawnTarget()
    {
        Vector3 position = new Vector3(Random.Range(-10.0F, 10.0F), Random.Range(-10.0F, 10.0F), distance);
        Instantiate (target, position, Quaternion.identity);
        
        targetAmount++;
    }
}
