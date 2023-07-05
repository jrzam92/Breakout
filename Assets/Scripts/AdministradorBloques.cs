using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorBloques : MonoBehaviour
{
    public GameObject MenuFinNivel;

    private void Update()
    {
        //Se pregunta cuantos hijos tiene y si este es 0 se activa el menu fin de nivel 
        if(transform.childCount== 0)
        {
            MenuFinNivel.SetActive(true);
        }
    }
}
