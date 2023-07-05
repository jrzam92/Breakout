using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueGold : Bloque
{
    void Start()
    {
        resistencia = 1;
        opciones = new Opciones();
        opciones.CambiarDificultad(resistencia);
    }
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}

