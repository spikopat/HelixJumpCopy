using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameManager))]
public class GameManagers : MonoBehaviour {

    private static GameManager _gameManager;
    public static GameManager Game {
        get { return _gameManager; }
    }

    private void Awake() {
        _gameManager = GetComponent<GameManager>();
    }

}