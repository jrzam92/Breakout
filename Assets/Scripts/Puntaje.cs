using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform transformPuntajeAlto;
    public Transform transformPuntajeActual;
    public TMP_Text txtPuntajeAlto;
    public TMP_Text txtActual;
    public PuntajeAlto puntajeAltoSO;
   
    // Start is called before the first frame update
    void Start()
    {
        transformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        transformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        txtActual=transformPuntajeActual.GetComponent<TMP_Text>();
        txtPuntajeAlto=transformPuntajeAlto.GetComponent<TMP_Text>();
        ///Forma de guardar en memoria el contenido del puntaje alto a la vieja escuela
        //if (PlayerPrefs.HasKey("PuntajeAlto"))
        //{
        //puntajeAlto = PlayerPrefs.GetInt("PuntajeAlto");
        //}
        puntajeAltoSO.Cargar();
            txtPuntajeAlto.text = $"Puntaje Alto: {puntajeAltoSO.puntajeAlto}";
        puntajeAltoSO.puntos = 0;
    }
    private void FixedUpdate()
    {
        puntajeAltoSO.puntos += 50;
    }
    // Update is called once per frame
    void Update()
    {
        txtActual.text = $"Puntaje Actual:{puntajeAltoSO.puntos}";
        if (puntajeAltoSO.puntos > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntos;
            txtPuntajeAlto.text = $"PuntajeAlto :{puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.Guardar();
           // PlayerPrefs.SetInt("PuntajeAlto", puntos);
        }
    }
}
