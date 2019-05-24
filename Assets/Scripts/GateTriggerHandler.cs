using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script that handle all trigger and gate
/// </summary>
public class GateTriggerHandler : MonoBehaviour
{
    public List<GateHandler> gatesGroup;

    // Start is called before the first frame update
    void Start()
    {
        SearchGate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SearchGate()
    {
        foreach(GateHandler gate in FindObjectsOfType<GateHandler>())
        {
            gatesGroup.Add(gate);
        }
    }

    //Open gate group1 and close gate group2
    public void ChangeGateState(int group1,int group2)
    {
        foreach(GateHandler gate in gatesGroup)
        {
            if(gate.group == group1)
            {
                gate.gameObject.SetActive(true);
            }
            else if(gate.group == group2)
            {
                gate.gameObject.SetActive(false);
            }
        }
       
    }
}
