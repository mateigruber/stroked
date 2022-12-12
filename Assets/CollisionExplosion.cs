using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionExplosion : MonoBehaviour
{
    private MeshExploder meshExploder;
    
    // Start is called before the first frame update
    void Start()
    {
        meshExploder = GetComponent<MeshExploder>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision) {
        meshExploder.Explode();
		GameObject.Destroy(gameObject);
    }
}
