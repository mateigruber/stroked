using Oculus.Interaction.Input;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class HandInjector : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        // TODO(mgruber): Inject both left/right hands.
        // TODO(mgruber): Remove these static references.
        Debug.LogWarning("XXX: InjectHand:  " + GameObject.Find("RightHand").GetComponent<Hand>());
        GetComponent<HandRef>().InjectHand(GameObject.Find("RightHand").GetComponent<Hand>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
