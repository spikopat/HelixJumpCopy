using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    Rigidbody rb;

    [SerializeField]
    GameObject splashObject;

    [SerializeField]
    float addForceY;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "RingPiece") {
            Debug.Log("RingPiece");
            rb.AddForce(new Vector3(0, addForceY, 0), ForceMode.Force);
            Instantiate(splashObject, collision.transform.position, Quaternion.identity);
        }
    }
}