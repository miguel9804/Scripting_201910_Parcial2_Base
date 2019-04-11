using UnityEngine;
using System.Collections;

public class FleeFromPlayer : Task
{
    [SerializeField]
    private float speed;
    private Vector3 seguir;
    private GameObject player;

    public override bool Execute()
    {   
        player = GameObject.FindGameObjectWithTag("Player");
        seguir = player.transform.position;
        float fixedSpeed = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, seguir, -fixedSpeed);
        Debug.Log("Alejandose del enemigo");
        return true;
    }
   
}