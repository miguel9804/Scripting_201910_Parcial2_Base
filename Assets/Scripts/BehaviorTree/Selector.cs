using UnityEngine;
using System.Collections;

public class Selector : Composite
{
    
    protected override bool ValueToBreak { get { return true; } }

    protected virtual bool CheckCondition() {

        return true;

    }
   

    public override bool Execute()
    {
        bool result = false;

        if (CheckCondition() == true)
        {
            return base.Execute();
        }

        return result;
    }
    
}