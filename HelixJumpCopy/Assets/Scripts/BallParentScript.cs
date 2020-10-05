using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallParentScript : MonoBehaviour {

    [SerializeField]
    Transform ballTransform;

    [HideInInspector]
    public float lowestYPos;

    private void Start() {
        lowestYPos = ballTransform.position.y;
    }

    private void Update() {
        if (ballTransform.position.y < lowestYPos) {
            lowestYPos = ballTransform.position.y;
        }
    }
}