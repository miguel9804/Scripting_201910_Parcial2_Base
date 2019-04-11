using UnityEngine;
using System.Collections;

public class IsPlayerNear : Selector
{
    private float radio = 10f;
    private GameObject player;
    protected override  bool CheckCondition()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        float dis = Vector3.Distance(player.transform.position, transform.position);
        if (dis < radio)
        {
            Debug.Log("Enemigo detectado");
            return true;
        }
        else
        {
            //Debug.Log("Enemigo no detectado");
            return false;
        }
    }
   
}