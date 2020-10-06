using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

    Rigidbody rb;

    [SerializeField]
    GameObject splashObject;

    [SerializeField]
    Transform splashParent;

    [SerializeField]
    float addForceY;

    private void Start() {
        rb = GetComponent<Rigidbody>();
    }

    //Dokunduğu noktaya SplashEffect spawnlayabilmek için bu kontrolü burada yapmam gerekti.
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "RingPiece") {

            Vector3 contactPoint = collision.contacts[0].point;
            Instantiate(splashObject, new Vector3(contactPoint.x, contactPoint.y + 0.1f, contactPoint.z), Quaternion.Euler(90, 0, 0), splashParent);

            rb.AddForce(new Vector3(0, addForceY, 0), ForceMode.Force);
        }
    }

}