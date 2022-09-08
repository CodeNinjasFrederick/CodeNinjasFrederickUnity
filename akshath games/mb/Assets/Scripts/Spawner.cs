using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spikes;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("InstantiateObjects", 1f, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void InstantiateObjects()
    {
        
        Instantiate(spikes, new Vector3(5, Random.Range(-height, height), 0), transform.rotation);
     //   transform.position = new Vector3(5, Random.Range(-height, height), 0);
    }
}
