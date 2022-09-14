using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class BaseSpawner : MonoBehaviour
{
    protected int spawnCount;

    protected float startTime;

    public TextMeshProUGUI timer;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        spawnCount = 10000;
        startTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
