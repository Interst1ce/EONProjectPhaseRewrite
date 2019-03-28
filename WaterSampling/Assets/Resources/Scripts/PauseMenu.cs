using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour {

    [SerializeField]
    GameObject[] toToggle;

    public void Pause() {
        AudioListener.pause = !AudioListener.pause;
        foreach(GameObject elem in toToggle) {
            elem.SetActive(!elem.activeSelf);
        }
     }
}
