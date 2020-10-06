using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPieceScript : MonoBehaviour {

    private void OnCollisionEnter(Collision collision) {
        if (collision.collider == null) {
            return;
        }
        if (collision.gameObject.tag == "Ball") {
            collision.gameObject.GetComponent<TrailRenderer>().enabled = false;
            GameManagers.Game.WinState();
        }
    }
}