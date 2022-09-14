using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalSpawner : BaseSpawner
{
    public GameObject prefab;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartSpawning()
    {
        startTime = 0;
        for (int i = 0; i < spawnCount; i++)
        {
            Instantiate(prefab, GetRandomLocation(), transform.rotation);
            startTime += Time.deltaTime;
        }


        timer.text = "Instantiate took: " + startTime + "ms";
    }

    public Vector3 GetRandomLocation()
    {
        float x = Random.Range(20, 50);
        float z = Random.Range(-50, 50);

        Vector3 randomPos = new Vector3(x, 2, z);

        return randomPos;
    }
}
