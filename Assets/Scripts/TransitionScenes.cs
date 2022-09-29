using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScenes : MonoBehaviour {

    [SerializeField]
    private int m_SceneIndex = 0;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player"){
            Debug.Log("Player has collided");
            SceneManager.LoadScene(m_SceneIndex);
        }    
    }
}
