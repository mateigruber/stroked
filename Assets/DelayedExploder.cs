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
using Oculus.Interaction;
using System.Collections;

public class DelayedExploder : MonoBehaviour {
    public float dimmingSpeed = 1;
    private float startOpacity = 0;
    public float endOpacity = 0.5f;

    public MeshExploder meshExploder;
    public SkinnedMeshRenderer skinnedMeshRenderer;

    private float tickerStartTime = 0;
    private bool isTicking = false;
    private bool isExploding = false;

    private Color outlineColor;
    public Color activeColor;


	void Start () {
        startOpacity = skinnedMeshRenderer.materials[0].GetFloat("_Opacity");
        outlineColor = skinnedMeshRenderer.materials[0].GetColor("_OutlineColor");
	}

	void Update () {
        if (isTicking) {
            float opacity = Mathf.SmoothStep(startOpacity, endOpacity, (Time.time - tickerStartTime) * dimmingSpeed);
            Debug.LogWarning("XXX: opacity " + opacity);
            skinnedMeshRenderer.materials[0].SetFloat("_Opacity", opacity);;
            if (Mathf.Approximately(opacity, endOpacity)) {
                Debug.LogWarning("XXX: isExploding " + isExploding);
                if (isExploding) {
                    return;
                }
                meshExploder.Explode();
                isTicking = false;
            }
        }
	}

    public void StartExplosion()
    {
        Debug.LogWarning("XXX: StartExplosion");
        tickerStartTime = Time.time;
        isTicking = true;
        skinnedMeshRenderer.materials[0].SetColor("_OutlineColor", activeColor);
    }

    public void StopExplosion() {
        Debug.LogWarning("XXX: StopExplosion");
        isTicking = false;
        skinnedMeshRenderer.materials[0].SetFloat("_Opacity", startOpacity);
        skinnedMeshRenderer.materials[0].SetColor("_OutlineColor", outlineColor);
    }
}
