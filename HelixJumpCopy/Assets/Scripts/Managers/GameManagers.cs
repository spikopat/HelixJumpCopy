using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameManager))]
[RequireComponent(typeof(SoundManager))]
[RequireComponent(typeof(UIManager))]
public class GameManagers : MonoBehaviour {

    private static GameManager _gameManager;
    public static GameManager Game {
        get { return _gameManager; }
    }

    private static SoundManager _soundManager;
    public static SoundManager Sound {
        get { return _soundManager; }
    }

    private static UIManager _uiManager;
    public static UIManager UI {
        get { return _uiManager; }
    }

    private void Awake() {
        _gameManager = GetComponent<GameManager>();
        _soundManager = GetComponent<SoundManager>();
        _uiManager = GetComponent<UIManager>();
    }

}