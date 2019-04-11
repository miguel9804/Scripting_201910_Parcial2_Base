using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICrear : MonoBehaviour
{
    private static int seg = 300;
    private int tiempo_espera = 300;
    void Update()
    {
        seg += 1;
        if(seg>tiempo_espera)
        {
            seg = 0;
            AICreacion.Instancia.Obtener_AI();
        }
    }
}
