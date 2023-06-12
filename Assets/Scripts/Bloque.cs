using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    ///Ideas de porwer up o debuff 
    ///===Congelamiento de bloque se disminuye la fuerza de bloque 
    ///===Velocidad a pelota cada vez que toque el bloque 
    ///===Fuego de bloque aumento de fuerza de bloque
    /// <summary>
    /// debuff al jugador dependiendo de que bloque pueda tocar este puede ir mas rapido o mas lento
    /// </summary>

    public int resistencia = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
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
