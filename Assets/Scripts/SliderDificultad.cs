using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderDificultad : MonoBehaviour
{
    public Opciones opciones;
    Slider slider;
    private void Start()
    {
        slider=GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { ControlarCambios(); }) ;
    }

    private void ControlarCambios()
    {
        opciones.CambiarVelocidad(slider.value);
    }
}
