using UnityEngine;
using System.Collections;

public class Attack : Task
{
    private float dis_disparo = 8f;
    private bool dispar;
    //private int tiempo_limite=10;
    //private int seg;
    private GameObject player;
    //private AICharacter ai;
    public override bool Execute()
    {
        Dispar();
        return dispar;
    }
    public void Dispar()
    {
        //seg += 1;
        player = GameObject.FindGameObjectWithTag("Player");
        float dis = Vector3.Distance(player.transform.position, transform.position);
        if (dis < dis_disparo)
        {
            /*if(seg>tiempo_limite)
            {
                ai.SpawnBullet();
                
            }*/
            Debug.Log("Disparar");
            dispar = true;
        }
        else
        {
            Debug.Log("No disparar");
            dispar = false;
        }
    }
}