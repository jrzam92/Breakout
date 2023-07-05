using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorVidas : MonoBehaviour
{
    [HideInInspector] public List<GameObject> vidas;
    public GameObject bolaPrefab;
    private Bola bolaScript;
    public GameObject MenuFinJuego;

    private void Start()
    {
        Transform[] hijos=GetComponentsInChildren<Transform>();
        foreach (Transform hijo in hijos)
        {
            vidas.Add(hijo.gameObject);
        }
    }

    public void EliminarVida()
    {
        var objetoAEliminar = vidas[vidas.Count-1];
       
        Destroy(objetoAEliminar);
        vidas.RemoveAt(vidas.Count-1);
        if(vidas.Count <= 0)
        {
            MenuFinJuego.SetActive(true);
        }
        var bola = Instantiate(bolaPrefab);
        bolaScript=bola.GetComponent<Bola>();
        bolaScript.BolaDestruida.AddListener(this.EliminarVida);
        Debug.Log($"Vidas restantes: {vidas.Count}");
    }
}
