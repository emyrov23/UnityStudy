using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject firstScreeen;
    [SerializeField] private GameObject secondScreeen;

    private GameObject currentSreeen;

    private void Start()
    {
        firstScreeen.SetActive(true);
        currentSreeen = firstScreeen;
    }

    public void ChangeState(GameObject state)
    {
        if (currentSreeen != null)
        {
            currentSreeen.SetActive(false);
            state.SetActive(true);
            currentSreeen = state;
        }
    }
}
