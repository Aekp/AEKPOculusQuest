using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaustVariableController : MonoBehaviour
{
    public FaustPlugin_glassHarmonica scriptFaust;
    public int dummy_Toggle = 1;
    public GameObject this_Object;
    public float bowPressure, intConstant;


    // Start is called before the first frame update
    void Start()
    {
        print("FAUSTVARIABLECONTROLLER: inside Start");
        scriptFaust = this_Object.GetComponent<FaustPlugin_glassHarmonica>();
        bowPressure = scriptFaust.getParameter(9);
        intConstant = scriptFaust.getParameter(7);
        //print("scriptFaust.parameters damp = " + wet);

    }

    // Update is called once per frame
    void Update()
    {
        if (dummy_Toggle == 1)
        {
            // setParameter(int param, float x)
            scriptFaust.setParameter(7, 0.6f);
            scriptFaust.setParameter(9, 0.2f);
            print("VALUE CHANGED! scriptFaust.getParameter(3)= " + (scriptFaust.getParameter(9)) + (scriptFaust.getParameter(7)));
            dummy_Toggle = 0;
        }
    }
}
