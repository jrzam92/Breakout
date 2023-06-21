using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public abstract class PuntajePersistente : ScriptableObject
{ 
    public void Guardar(string NombreArchivo=null)
    {
        var bf = new BinaryFormatter();
        var file = File.Create(GetPath(NombreArchivo));
        var json = JsonUtility.ToJson(this);

        bf.Serialize(file, json);   
        file.Close();
    }

    public virtual void Cargar(string nombreArchivo=null)
    {
        if(File.Exists(GetPath(nombreArchivo)))
        {
            var bf = new BinaryFormatter();
            var archivo=File.Open(GetPath(nombreArchivo),FileMode.Open);
            JsonUtility.FromJsonOverwrite((string)bf.Deserialize(archivo), this);
            archivo.Close();
        }
    }
    public string GetPath(string nombrArchivo=null)
    {
        var nombreArchivoCompleto=string.IsNullOrEmpty(nombrArchivo)?name : nombrArchivo;
        return string.Format("{0}/{1}.ebac",Application.persistentDataPath,nombreArchivoCompleto);
    }
}
