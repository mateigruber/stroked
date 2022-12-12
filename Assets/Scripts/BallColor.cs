using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColor : MonoBehaviour
{
    public Renderer myRenderer;
    private Rigidbody rigidBody;
    public Color collisionColor;
    private Color defaultColor;
    private Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        rigidBody = GetComponent<Rigidbody>();
        defaultColor = myRenderer.material.color;
        Debug.LogWarning("Starting: " + name);
        originalPosition = Vector3.zero + gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision other) {
        Debug.LogWarning("Enter collision with: " + other.gameObject.name);
        if (other.gameObject.CompareTag("RightHand")) {
            myRenderer.material.color = collisionColor;
        }
    }

    public void OnCollisionExit(Collision other) {
        Debug.LogWarning("Exit collision with: " + other.gameObject.name);
        if (other.gameObject.CompareTag("RightHand")) {
            myRenderer.material.color = defaultColor;
        }
    }

    public void OnTriggerExit(Collider other) {
        Debug.LogWarning("Exit trigger with: " + other.gameObject.name);
    }

    public void OnTriggerEnter(Collider other) {
        Debug.LogWarning("Enter trigger with: " + other.gameObject.name);
    }

    public void OnTriggerStay(Collider other) {
        Debug.LogWarning("Stay trigger with: " + other.gameObject.name);
    }
}
