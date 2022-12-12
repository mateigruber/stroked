/*
 * Copyright (c) Meta Platforms, Inc. and affiliates.
 * All rights reserved.
 *
 * Licensed under the Oculus SDK License Agreement (the "License");
 * you may not use the Oculus SDK except in compliance with the License,
 * which is provided at the time of installation or download, or which
 * otherwise accompanies this software in either electronic or hard copy form.
 *
 * You may obtain a copy of the License at
 *
 * https://developer.oculus.com/licenses/oculussdk/
 *
 * Unless required by applicable law or agreed to in writing, the Oculus SDK
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


using UnityEngine;
using System.Collections;

public class TeleportPoint : MonoBehaviour {

    public float dimmingSpeed = 1;
    public float fullIntensity = 1;
    public float lowIntensity = 0.5f;

    public Transform destTransform;

    private float lastLookAtTime = 0;
    private bool isLookingAt = false;
    private bool isChangingExercise = false;



	// Use this for initialization
	void Start () {

	}

    public Transform GetDestTransform()
    {
        return destTransform;
    }




	// Update is called once per frame
	void Update () {
        if (isLookingAt) {
            float intensity = Mathf.SmoothStep(lowIntensity, fullIntensity, (Time.time - lastLookAtTime) * dimmingSpeed);
            GetComponent<MeshRenderer>().material.SetFloat("_Intensity", intensity);

            if (Mathf.Approximately(intensity, fullIntensity)) {
                // Perform teleportation.
                // TODO(mgruber): Add fade effect.
                Debug.LogWarning("XXX: isChangingExercise " + isChangingExercise);
                if (isChangingExercise) {
                    return;
                }
                isChangingExercise = true;
                StartCoroutine(GoToNextExercise(destTransform.position, destTransform.rotation, /*waitTime=*/ 0.5f));
            }
        }
	}

    public void OnLookAt()
    {
        lastLookAtTime = Time.time;
        isLookingAt = true;
    }

    public void OnLookAway() {
        isLookingAt = false;
        GetComponent<MeshRenderer>().material.SetFloat("_Intensity", lowIntensity);
    }

    private IEnumerator GoToNextExercise(Vector3 position, Quaternion rotation, float waitTime) {
        yield return new WaitForSeconds(waitTime);
        FindObjectOfType<OVRCameraRig>().transform.position = position;
        FindObjectOfType<OVRCameraRig>().transform.rotation = rotation;
        yield return new WaitForSeconds(waitTime);

        // TODO(mgruber): Pass the whole transform.
        FindObjectOfType<ExerciseManager>().InstantiateNextExerciseAt(position, rotation);
        isChangingExercise = false;
        // The hand might still be placed in the teleport object even after changing the scene,
        // until it's position is re-computed based on the OVRCamerRig.
        OnLookAway();
    }
}
