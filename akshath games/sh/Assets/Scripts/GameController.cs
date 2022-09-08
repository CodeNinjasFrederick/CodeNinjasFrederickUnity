using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [Header("platform object")]
    public GameObject platform;
    float pos = 0;
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<1000; i++)
        {
            SpawnPlatforms();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnPlatforms()
    {
        Instantiate(platform, new Vector3(Random.value * 10 - 5f, pos, 0.5f), Quaternion.identity);
        pos += 2.5f;                
    }
}
