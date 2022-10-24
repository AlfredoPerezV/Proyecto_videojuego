using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    float movimiento = 5f;
    public bool isGraunded;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * movimiento * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * movimiento * Time.deltaTime;
        transform.Translate(x, 0, z);
        //Salto y restriccion de salto
        if (Input.GetKeyDown(KeyCode.Space) && isGraunded == true)
        {
            rb.AddForce(0f, 4f, 0f, ForceMode.Impulse);
            isGraunded = false;
        }
       
        
    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.tag == "Plataforma")
        {
            isGraunded = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Respawn")
        {
            transform.position = new Vector3(0.75f, 34.18f, -4.39f);
        }
    }
}
