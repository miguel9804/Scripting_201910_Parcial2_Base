using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : State
{
    public override void Execute()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        float dis = Vector3.Distance(player.transform.position, transform.position);
        if(dis<WarningState && dis>ActState)
        {
            
            transform.LookAt(player.transform);
            Debug.Log("Estado alarta");
        }
       
    }

   
  
}
