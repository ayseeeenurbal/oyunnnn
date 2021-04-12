using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnaCember : MonoBehaviour
{
    public GameObject kucukCember;
    GameObject OyunYoneticisi;
    void Start()
    {
        OyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyonettag");
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            kucukCemberOlustur();
        }
    }
    void kucukCemberOlustur()
    {
        Instantiate(kucukCember, transform.position, transform.rotation);
        OyunYoneticisi.GetComponent<OyunYonet>().KucukCemberlerdeTextGosterme();
    }
}
