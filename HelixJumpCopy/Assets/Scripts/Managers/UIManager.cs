using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject activeMenu;

    [Space]
    public InGameUI inGameUI;

    //Mevcut menüyü kapatır, parametre olarak gönderilen menüyü açar.
    public void ChangeActiveMenu(GameObject newPanel) {
        if (activeMenu != null) {
            activeMenu.SetActive(false);
        }
        activeMenu = newPanel;
        activeMenu.SetActive(true);
    }

    private void Start() {
        ChangeActiveMenu(inGameUI.gameObject);
    }

}