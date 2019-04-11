using UnityEngine;
using System.Collections;

public class Idle : State
{
    
    public override void Execute()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
        float dis = Vector3.Distance(player.transform.position, transform.position);
        if(dis>WarningState)
        {
            Debug.Log("Estado tranquilo");
        }
    }
}