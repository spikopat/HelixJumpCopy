using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroyScript : MonoBehaviour {

    [SerializeField]
    float destroyAfter;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Ball") {
            Destroy(transform.parent.gameObject, destroyAfter);
            GameManagers.UI.inGameUI.CurrentScore += 2;
        }
    }

}