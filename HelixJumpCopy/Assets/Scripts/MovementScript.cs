﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    private void Update() {
        transform.Rotate(Vector3.up * Input.GetAxis("Horizontal"));
    }

}