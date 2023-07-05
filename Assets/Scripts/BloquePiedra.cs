using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloquePiedra : Bloque
{
    
    // Start is called before the first frame update
    void Start()
    {
        resistencia = 0;
        opciones = new Opciones();
        opciones.CambiarDificultad(resistencia);
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
