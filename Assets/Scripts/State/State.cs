using UnityEngine;

public abstract class State : MonoBehaviour
{
    [SerializeField]
    private State nextState;
    private float warningState = 20f;
    private float actState=12f;
    protected GameObject player;

    protected float WarningState
    {
        get
        {
            return warningState;
        }
    }
    protected float ActState {
        get
        {
            return actState;
        }
    }

    public abstract void Execute();

    private void SwitchToNextState()
    {
        if (nextState != null)
        {
            Toggle(false);
            nextState.Toggle(true);
        }
    }

    public void Toggle(bool val)
    {
        this.enabled = val;

        if (val)
        {
            Execute();
        }
    }
    private void Update()
    {
        Toggle(true);
    }
}