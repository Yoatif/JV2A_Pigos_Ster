using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopFalling : MonoBehaviour
{
    [SerializeField]
    private GameObject Stele;
    [SerializeField]
    private GameObject Floor;

    
    // Start is called before the first frame update
    void Start()
    {
        //Stele.GetComponent<Collider2D>().enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //if(Stele == Floor)
        //{
        //    Stele.GetComponent<Collider2D>().isTrigger = false;
        //}
        if (collision.tag == "Stele")
        {
            Stele.GetComponent<Collider2D>().isTrigger = false;
        }

    }
}
