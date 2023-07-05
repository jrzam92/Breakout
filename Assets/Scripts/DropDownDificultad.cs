using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownDificultad : MonoBehaviour
{
    public Opciones opciones;
    //Dropdown dificultad;
    public TMPro.TMP_Dropdown dificultad;//Se realiza un cambio por la nueva actualizacion de unity 
    private void Start()
    {
        dificultad = this.GetComponent<TMPro.TMP_Dropdown>();
        dificultad.onValueChanged.AddListener(delegate { opciones.CambiarDificultad(dificultad.value); });
        //Debug.Log(dificultad);
    }
}
