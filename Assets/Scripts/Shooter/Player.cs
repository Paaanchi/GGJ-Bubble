using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject attack;
    public Transform PuntoDisparo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject AtaqueInstanciada = Instantiate(attack, PuntoDisparo.position, PuntoDisparo.rotation);
            Rigidbody2D rbAtaque = AtaqueInstanciada.GetComponent<Rigidbody2D>();
            Vector3 direccion = (PuntoDisparo.position - (Vector3)transform.position).normalized;
            rbAtaque.AddForce(direccion * 10f, ForceMode2D.Impulse);
        }
    }
}
