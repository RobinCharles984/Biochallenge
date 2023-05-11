using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PiperSpawner : MonoBehaviour
{
    public float maxTime;
    private float time = 0;
    public GameObject pipe;
    public float height;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height));
        Destroy(newPipe, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if (time > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height));
            Destroy(newPipe, 10);

            time = 0;
        }

        time += Time.deltaTime;
    }
}
