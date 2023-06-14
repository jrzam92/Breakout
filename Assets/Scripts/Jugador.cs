using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    [SerializeField] public int limitX = 23;
    [SerializeField] public float VelocidadPaaddle;
    Rigidbody rigidbody;
    Vector3 mousePos2D;
    Vector3 mousePos3D;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float InputKeyH = Input.GetAxis("Horizontal");
        float InputKeyV = Input.GetAxis("Vertical");

       //Forma de moverlo con el teclado 
       ///Recordar que depende de la ventana o la forma este Vector3 puede cambiar por lo que se 
       ///debe de encontrar la adaptacion correspondiente 
       transform.Translate(Vector3.down * Time.deltaTime * VelocidadPaaddle * InputKeyH);
        //Forma de moverlo con el mouse
       ///GetComponent<Rigidbody>().position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, -Camera.main.transform.position.z));
        
        //Condicion para dar limite a la posicion de un objeto
        if (transform.position.x < -limitX)
        {
            transform.position = new Vector3(-limitX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > limitX)
        {
            transform.position = new Vector3(limitX, transform.position.y, transform.position.z);

        }

    }
}
