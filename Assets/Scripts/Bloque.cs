using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    ///Ideas de porwer up o debuff 
    ///===Congelamiento de bloque se disminuye la fuerza de bloque 
    ///===Velocidad a pelota cada vez que toque el bloque 
    ///===Fuego de bloque aumento de fuerza de bloque
    /// <summary>
    /// debuff al jugador dependiendo de que bloque pueda tocar este puede ir mas rapido o mas lento
    /// </summary>
    public Opciones.dificultad dificultad;
    public Opciones opciones;
    public int resistencia = 0;
    public UnityEvent aumentarPuntaje;

    //Este se usa cuando algo choca con este objeto
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point-transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.velocity = collision.gameObject.GetComponent<Bola>().velocidadBola * direccion;
        resistencia--;
    }

    // Start is called before the first frame update
    void Start()
    {
        
       opciones.CambiarDificultad(((int)dificultad), resistencia);


    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
            aumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }
    /// <summary>
    /// Sobre carga de metodo
    /// </summary>
    public virtual void RebotarBola()
    {

    }
}
