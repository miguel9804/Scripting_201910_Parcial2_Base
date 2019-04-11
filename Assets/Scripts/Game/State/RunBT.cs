using UnityEngine;

public class RunBT : State
{
    [SerializeField]
    protected Root btRoot;

    public override void Execute()
    {
        /*player = GameObject.FindGameObjectWithTag("Player");
        float dis = Vector3.Distance(player.transform.position, transform.position);
        if (dis < ActState)
        {
            if (btRoot != null)
            {

                btRoot.Execute();
            }
            
        }*/
        
    }
}