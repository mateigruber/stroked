using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.TrailRenderer;

public class TrailChanger : MonoBehaviour
{
    public GameObject trailObject;
    private TrailRenderer trailRenderer;
    private float timer;
    private float lastCollisionEnterTime = 0.0f;



    // Start is called before the first frame update
    void Start()
    {
        trailRenderer = trailObject.GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    public void EndTrailRenderer() {
        Debug.LogWarning("XXX EndTrailRenderer: " + trailRenderer);
        trailRenderer.enabled = false;
    }

    public void StartTrailRenderer() {
        Debug.LogWarning("XXX StartTrailRenderer: " + trailRenderer);
        if (timer - lastCollisionEnterTime > 0.5f) {
            // Allow .5s of tolerance outside of the trace before clearing it.
            trailRenderer.Clear();    
        }
        lastCollisionEnterTime = timer;
        trailRenderer.enabled = true;
    }
}
