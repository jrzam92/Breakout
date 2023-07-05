using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueMadera : Bloque
{
    // Start is called before the first frame update
    void Start()
    {
        resistencia =0;
        opciones = new Opciones();
        opciones.CambiarDificultad(resistencia);
    }
    /// <summary>
    /// Sobrecarga del metodo heredada de Bloque
    /// </summary>
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }

}
