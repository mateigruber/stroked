using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddImpulse : MonoBehaviour
{
    public Vector3 direction;
    public float radius = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable() {
        Debug.LogWarning("XXX: OnEnable");
        AddRandom();
    }

    public void AddRandom() {
        Vector3 eps = new Vector3(UnityEngine.Random.Range(-radius, radius),
            UnityEngine.Random.Range(-radius, radius),
            0.0f);
        GetComponent<Rigidbody>().AddForce(direction + eps, ForceMode.Impulse);
    }
}
