﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectibles : MonoBehaviour
{
    // Start is called before the first frame update
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
    }
}
