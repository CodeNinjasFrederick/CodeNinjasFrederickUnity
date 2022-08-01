using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    // After this time, the object will be destroyed
    public float timeToDestruction;


    void Start()
    {
        Invoke("DestroyMe", timeToDestruction);
    }


    // This function will destroy this object :(
    void DestroyMe()
    {
        Destroy(gameObject);

        // Bye bye!
    }
}

