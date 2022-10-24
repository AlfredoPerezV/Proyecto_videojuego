using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reaparacion : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
           transform.position = new Vector3(0.75f, 34.18f, -4.39f);
        }
    }
}
