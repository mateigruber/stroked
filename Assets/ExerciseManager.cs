using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExerciseManager : MonoBehaviour
{
    public ExerciseList exerciseList;

    private GameObject currentExercise;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject InstantiateNextExerciseAt(Vector3 position, Quaternion rotation) {
        if (currentExercise != null) {
            Destroy(currentExercise);
        }
        GameObject destExercisePrefab = gameObject.GetComponent<ExerciseList>().GetNextExercise();
        Debug.LogWarning("XXX destExercise: " + destExercisePrefab);
        currentExercise = Instantiate(destExercisePrefab, position, rotation).gameObject;
        return currentExercise;
    }



}
