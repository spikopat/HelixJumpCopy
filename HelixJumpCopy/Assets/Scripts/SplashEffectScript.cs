using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashEffectScript : MonoBehaviour {

    [SerializeField]
    float timeAfterDestroy;

    private void Start() {
        Destroy(gameObject, timeAfterDestroy);
    }

}