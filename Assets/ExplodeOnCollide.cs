using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnCollide : MonoBehaviour
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

    public void ExplodeAndDestroy() {
        Debug.LogWarning("XXX: ExplodeAndDestroy");
        meshExploder.Explode();
		GameObject.Destroy(gameObject);
    }
}
