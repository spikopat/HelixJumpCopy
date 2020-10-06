using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public bool isGameActive;

    private void Awake() {
        IsGameActive(true);
    }

    public void WinState() {
        IsGameActive(false);
        Debug.Log("WinState");
    }

    public void LostState() {
        IsGameActive(false);
        Debug.Log("LostState");
    }

    public void IsGameActive(bool value) {
        if (value) {
            Time.timeScale = 1;
        }
        else {
            Time.timeScale = 0;
        }
    }
}