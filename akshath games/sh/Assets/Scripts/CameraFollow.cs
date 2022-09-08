using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("follow...")]
    public Transform target;
    // Start is called before the first frame update
  

    // Update is called once per frame
    private void Update()
    {
        if (target.position.y > transform.position.y)
        {
            transform.position = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.x);
        }
    }
}
