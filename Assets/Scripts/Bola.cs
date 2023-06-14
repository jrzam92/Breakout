using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
   public bool isGameStarted=false;
    [SerializeField] public float velocidadBola = 10f;
    // Start is called before the first frame update
    void Start()
    {
       //Vector tres que busque la posicion de jugador, para que tenga la herencia y hacer el parent con el jugador 
       Vector3  positionStart=GameObject.FindGameObjectWithTag("Jugador").transform.position;
        positionStart.y += 3;
        transform.position = positionStart;
        transform.SetParent(GameObject.FindGameObjectWithTag("Jugador").transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) || Input.GetButton("Submit"))
        {
            isGameStarted = true;
            transform.SetParent(null);
            GetComponent<Rigidbody>().velocity = velocidadBola * Vector3.up;
        }
    }
}
