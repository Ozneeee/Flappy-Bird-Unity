using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedSpawn : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;


    public float maxTime = 1;
    private float timer = 0;
    public float height;

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(spawnee, transform.position, transform.rotation); // rotation ici
        
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }

    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newspawnee = Instantiate(spawnee);
            newspawnee.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newspawnee, 10);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
