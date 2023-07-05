using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueBronce : Bloque
{
    void Start()
    {
        resistencia = 2;
        opciones = new Opciones();
        opciones.CambiarDificultad(resistencia);
    }
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
