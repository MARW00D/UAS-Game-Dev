using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author BY MRWD
public class Player : MonoBehaviour
{
    public int kecepatan; 
    public int pindah;
    Animator anim;

    public bool Uibtnkiri , Uibtnkanan ;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //gerak kanan kiri (non animasi)
        if (Input.GetKey(KeyCode.D) || (Uibtnkanan == true))
       
        {
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
            pindah = -1; 

        } else if (Input.GetKey(KeyCode.A) || (Uibtnkiri == true))
    
        {
            transform.Translate(Vector2.right * -kecepatan * Time.deltaTime); 
            pindah = 1; 
        }
        
        //gerak animasi
        if (Input.GetKey(KeyCode.L)) {
            anim.SetBool("hajar",true);
        } else {
            anim.SetBool("hajar",false);
        }

        if (Input.GetKey(KeyCode.K)) {
            anim.SetBool("sepak",true);
        } else {
            anim.SetBool("sepak",false);
        }      
    }
    public void tekankiri(){
        Uibtnkiri = true;
    }
    public void lepaskiri(){
        Uibtnkiri = false;
    }

    public void tekankanan(){
        Uibtnkanan = true;
    }
    public void lepaskanan(){
        Uibtnkanan = false;
    }
}
