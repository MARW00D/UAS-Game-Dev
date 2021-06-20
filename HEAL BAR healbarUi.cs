using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Author BY MRWD

public class healbarUi : MonoBehaviour
{
    // Start is called before the first frame update
    Image Barheal;
    float KesehatanMax = 100f;
    public static float Kesehatan;
    
    void Start()
    {
        Barheal = GetComponent<Image>();
        Kesehatan = KesehatanMax;
    }

    // Update is called once per frame
    void Update()
    {
        Barheal.Fillamount=Kesehatan/KesehatanMax;
    }
}
