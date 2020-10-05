using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour {

    [SerializeField]
    BallParentScript target;

    [SerializeField]
    Vector3 offset;

    Transform targetTransform;

    private void Start() {
        targetTransform = target.transform;
    }

    private void FixedUpdate() {
        Vector3 desiredPosition = new Vector3(targetTransform.position.x + offset.x, target.lowestYPos + offset.y, targetTransform.position.z + offset.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, 0.125f);
        transform.position = smoothedPosition;
    }

}