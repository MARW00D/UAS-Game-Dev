﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author BY MRWD
public class koin : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("Player"))
        {
            print("cincin diambil");
            Destroy(gameObject);
            scorecoincincin.hitungcoin += 10;
            
        }
    }
}
