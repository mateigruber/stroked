using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour, ICollidable
{
    bool isColliding;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        isColliding = true;
    }

    void OnTriggerExit(Collider other) {
        isColliding = false;
    }

    public bool IsColliding() {
        return isColliding;
    }
}
