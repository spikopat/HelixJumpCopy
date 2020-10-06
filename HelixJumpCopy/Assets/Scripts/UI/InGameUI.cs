using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InGameUI : MonoBehaviour {

    public TextMeshProUGUI currentScoreTextValue;

    private int currentScore;
    public int CurrentScore {
        get {
            return currentScore;
        }
        set {
            currentScore = value;
            currentScoreTextValue.text = currentScore.ToString();
        }
    }

    private void Start() {
        CurrentScore = 0;
    }
}