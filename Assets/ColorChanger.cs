using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Material collidingMaterial, nonCollidingMaterial;
    [SerializeField] private IScorer scorer;

    

    // Start is called before the first frame update
    void Start() {
    } 

    // Update is called once per frame
    void Update() {
    }


    public void OnTriggerExit(Collider other) {
        Debug.LogWarning("Exit trigger with: " + other.gameObject.name);
        gameObject.GetComponent<Renderer>().material = nonCollidingMaterial;
    }

    public void OnTriggerEnter(Collider other) {
        Debug.LogWarning("Enter trigger with: " + other.gameObject.name);
        gameObject.GetComponent<Renderer>().material = collidingMaterial;
    }

    public void OnTriggerStay(Collider other) {
        Debug.LogWarning("Stay trigger with: " + other.gameObject.name);
    }
}
