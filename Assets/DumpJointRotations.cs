using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class DumpJointRotations : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DumpJoints() {
        Debug.LogWarning("XXX: DumpJoints");

        Debug.LogWarning("XXX: RightJoints");
        foreach (Transform t in GameObject.Find("RightHandVisual").GetComponent<HandVisual>().Joints) {
            Debug.LogWarning("XXX: " + t + "\t" + t.rotation.eulerAngles);
        }
        Debug.LogWarning("XXX: LeftJoints");
        foreach (Transform t in GameObject.Find("LeftHandVisual").GetComponent<HandVisual>().Joints) {
            Debug.LogWarning("XXX: " + t + "\t" + t.rotation.eulerAngles);
        }
    }
}
