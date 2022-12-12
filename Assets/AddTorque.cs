using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddTorque : MonoBehaviour
{
    public ForceMode forceMode = ForceMode.Force;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddTorque(transform.up * 3, forceMode);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
