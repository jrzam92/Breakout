using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

[CreateAssetMenu(fileName ="Opciones",menuName ="Herramientas/Opciones",order = 1)]
public class Opciones : PuntajePersistente
{
    public float velocidadBola = 30;
    public dificultad NivelDificultad = dificultad.facil;
    public enum dificultad
    {
        facil,
        normal,
        dificil
    }
    
    public void CambiarVelocidad(float nuevaVelocidad)
    {
        velocidadBola += nuevaVelocidad;
    }

    public float CambiarVelocidadBola(float nuevaDificultad)
    {
        float nuevaVelocidad = 0.0f;
        NivelDificultad = (dificultad)nuevaDificultad;
        switch (NivelDificultad)
        {
            case dificultad.facil:
                nuevaVelocidad = 20.0f;
                break;
            case dificultad.normal:
                nuevaVelocidad = 30.0f;
                break;
            case dificultad.dificil:
                nuevaVelocidad =40.0f;
                break;
        }
        return nuevaVelocidad;
    }
    public void CambiarDificultad(int nuevaDificultad,int resistencia=0)
    {
        NivelDificultad = (dificultad)nuevaDificultad;
        switch (NivelDificultad)
        {
            case dificultad.facil:
                resistencia = resistencia;
                break; 
            case dificultad.normal:
                resistencia += resistencia;
                break;
            case dificultad.dificil:
                resistencia += resistencia + 1;
                break;
        }
    }
}