using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2d(Collision2D collision)
    {
        //if (collision.collider.tag == "Enemy")
        //{
        //    Debug.Log("We hit an enemy.");
        //}
        Debug.Log("We hit something");
    }
}
