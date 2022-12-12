using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialTeleport : MonoBehaviour
{
    public Transform destTransform;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = destTransform.position;
        gameObject.transform.rotation = destTransform.rotation;
        FindObjectOfType<ExerciseManager>().InstantiateNextExerciseAt(destTransform.position, destTransform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
