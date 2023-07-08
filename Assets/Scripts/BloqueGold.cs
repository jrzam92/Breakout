using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueGold : Bloque
{
   
    void Start()
    {
        resistencia = 1;
        
    }
    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}

