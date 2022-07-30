using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleAttribute : MonoBehaviour
{

    [Header("Value of Object")]
    public int pointsWorth = 1;

    [Header("Particle effect (if any)")]
    public GameObject pickupEffect;

    [Header("Game Object that has the Score Script")]
    public GameObject scoreUI;

    private void Start()
    {

    }

    // This function gets called everytime this object collides with another
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (pickupEffect)
        {
            Instantiate(pickupEffect, transform.position, transform.rotation);
        }

        if (scoreUI)
        {
            scoreUI.GetComponent<Score>().AddScore(pointsWorth);
        }

        Destroy(gameObject);
    }
}


