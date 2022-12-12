using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseList : MonoBehaviour
{
    public List<GameObject> exercises;
    private int index = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject GetNextExercise() {
        if (exercises.Count == 0) {
            return null;
        }
        GameObject nextExercise = exercises[index];
        Debug.LogWarning("XXX: nextExercise: " + nextExercise);
        index = (index + 1) % exercises.Count;
        return nextExercise;
    }
}
