using UnityEngine;
using System.Collections;


public class AICharacter : Character
{
    private State currentState;
    [SerializeField]
    private GameObject Ai;

    public void SetNewState(State newState)
    {
        currentState = newState;
       
    }
    protected override void OnDeath()
    {
        AICreacion.Instancia.Pegar(Ai);
    }

}