using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcember : MonoBehaviour
{
    Rigidbody2D fizik;
    public float hiz;
    bool hareketkontrol = false;
    GameObject oyunYoneticisi;
    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        oyunYoneticisi = GameObject.FindGameObjectWithTag("oyunyonettag");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!hareketkontrol)
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D col)

    {
        if (col.tag == "donencembertag")
        {
            transform.SetParent(col.transform);
            hareketkontrol = true;
        }
        if (col.tag=="kucukcembertag")
        {
            oyunYoneticisi.GetComponent<OyunYonet>().OyunBitti();
   
        }

    }
}
