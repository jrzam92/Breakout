using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorPersistencia : MonoBehaviour
{
    public List<PuntajePersistente> ObjetosAGuardar;
    // Start is called before the first frame update
    public void OnEnable()
    {
        for (int i = 0; i < ObjetosAGuardar.Count; i++)
        {
            var so = ObjetosAGuardar[i];
            so.Cargar();
        }
    }
    public void OnDisable()
    {
        for (int i = 0; i < ObjetosAGuardar.Count; i++)
        {
            var so = ObjetosAGuardar[i];
            so.Guardar();
        }
    }
}
