using UnityEngine;
using System.Collections;
[RequireComponent (typeof (Collision))]
public class DoKamikazeAttack : Task
{
   
    private const string PLAYER = "Player";
    private bool valor;
    public override bool Execute()
    {
        return valor;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag.Equals(PLAYER))
        {
            
            Debug.Log("Exploto");
            Destroy(this.gameObject);
            valor = true;
            
        }
        else
        {
            valor = false;
            Debug.Log("Nada");
        }
    }
}