using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bola : MonoBehaviour
{
     
    public bool isGameStarted=false;
    [SerializeField] public float velocidadBola = 10.0f;
    Vector3 ultimaPosicion=Vector3.zero;
    Vector3 direccion=Vector3.zero;
    Rigidbody rigidbody;
    private ControlBordes control;
    public UnityEvent BolaDestruida;

    private void Awake()
    {
        control = GetComponent<ControlBordes>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        isGameStarted = false;
       //Vector tres que busque la posicion de jugador, para que tenga la herencia y hacer el parent con el jugador 
       Vector3  positionStart=GameObject.FindGameObjectWithTag("Jugador").transform.position;
        positionStart.y += 3;
        transform.position = positionStart;
        transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(control.salioAbajo)
        {
            BolaDestruida.Invoke();
            Destroy(this.gameObject);
        }
        if(control.salioArriba)
        {
            direccion=transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde superior");
            direccion.y *= -1;
            direccion.Normalize();
            rigidbody.velocity=velocidadBola*direccion;
            control.salioArriba = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }
        if (control.salioDerecha)
        {
            direccion = transform.position - ultimaPosicion;
            Debug.Log("La bola toco el borde derecho");
            direccion.x *= -1;
            direccion.Normalize();
            rigidbody.velocity = velocidadBola * direccion;
            control.salioDerecha = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }
        if (control.salioIzquierda)
        {
            direccion = transform.position -ultimaPosicion;
            Debug.Log("La bola toco el borde izquierdo");
            direccion.x *= -1;
            direccion.Normalize();
            rigidbody.velocity = velocidadBola * direccion;
            control.salioIzquierda = false;
            control.enabled = false;
            Invoke("HabilitarControl", 0.5f);
        }
       


        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit"))
        {
            isGameStarted = true;
            transform.SetParent(null);
            GetComponent<Rigidbody>().velocity = velocidadBola * Vector3.up;
        }
    }
    private void FixedUpdate()
    {
        ultimaPosicion=transform.position;
    }
    private void LateUpdate()
    {
        if(direccion!=Vector3.zero) { direccion=Vector3.zero; }
    }

    private void HabilitarControl() {
        control.enabled = true;
    }
}
