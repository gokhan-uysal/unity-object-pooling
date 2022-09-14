using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PoolingSpawner : BaseSpawner
{
    public Stack objectStack;


    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

        objectStack.FullStack(spawnCount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSpawning()
    {
        startTime = 0;
        for(int i = 0; i < spawnCount; i++)
        {
            objectStack.InstantiateNewPrefab(GetRandomLocation() , transform.rotation);
            startTime += Time.deltaTime;
        }


        timer.text = "Pooling took: " + startTime + "ms";
    }

    public Vector3 GetRandomLocation()
    {
        float x = Random.Range(-50, -20);
        float z = Random.Range(-50, 50);

        Vector3 randomPos = new Vector3(x, 2, z);

        return randomPos;
    }
}
