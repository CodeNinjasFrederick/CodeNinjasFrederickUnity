using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAnimation : MonoBehaviour
{
    
        [Header("Animator")]
        public Animator animator;

        void Start()
        {
            animator = GetComponent<Animator>();
        }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");

        animator.SetFloat("HAxis", horizontal);
    }
}
