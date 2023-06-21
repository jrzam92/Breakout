using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="PuntajeAlto",menuName ="Herramientas/PuntajeAlto",order =0)]
public class PuntajeAlto : PuntajePersistente
{
    //No tiene acceso de a los start ni update 
    public int puntos = 0;
    public int puntajeAlto = 1000;
}
