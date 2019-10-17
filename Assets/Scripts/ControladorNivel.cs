using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorNivel : MonoBehaviour
{
    public static ControladorNivel Instancia = null;

    void Awake()
    {
        Instancia = this;
    }

    void OnDestroy()
    {
        Instancia = null;
    }

    public void RebentouBalao()
    {
        Debug.Log("Rebentou!");
    }
}
