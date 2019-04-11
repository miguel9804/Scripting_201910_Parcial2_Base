using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICreacion : MonoBehaviour
{
    private static AICreacion instancia;

    public static AICreacion Instancia { get => instancia; }
    [SerializeField]
    private GameObject AI;
    [SerializeField]
    private int size;
    [SerializeField]
    private Transform aparicion;
    private List<GameObject> ai;
    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            Ai();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Ai ()
    {
        ai = new List<GameObject>();
        for (int i = 0; i < size; i++)
        {
            Agregar_AI();
        }
    }
    private void Agregar_AI()
    {
        GameObject temp;
        temp = Instantiate(AI);
        temp.transform.position = aparicion.position;
        temp.gameObject.SetActive(false);
        ai.Add(temp);
    }
    public void Pegar(GameObject ene)
    {
       ene.gameObject.SetActive(false);
        ene.transform.position = aparicion.position;
        ai.Add(ene);
    }
    public GameObject Obtener_AI()
    {
        if (ai.Count == 0)
        {
            Agregar_AI();
        }
        return Activar_AI();
    }
    private GameObject Activar_AI()
    {
        GameObject temp = ai[ai.Count - 1];
        ai.RemoveAt(ai.Count - 1);
        temp.gameObject.SetActive(true);
        return temp;

    }

}
