﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Author BY MRWD

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other){
        healbarUi.Kesehatan-=25f;
    }
}
