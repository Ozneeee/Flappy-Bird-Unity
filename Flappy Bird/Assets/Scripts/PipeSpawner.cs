using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject pipe;
    public float height;

    void Start()
    {
        
    }

    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newpipe, 10);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
