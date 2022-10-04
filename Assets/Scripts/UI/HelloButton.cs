using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Button))]
public class HelloButton : MonoBehaviour {
    public Button startButton;
    // Start is called before the first frame update
    void Start() {
        var root = gameObject.GetComponent<UIDocument>().rootVisualElement;

        startButton = root.Q<Button>("GreenButton");
        startButton.clicked += LoadCurrentScene;
        
    }

    void LoadCurrentScene() {
        Debug.Log("Hi Mom!");
    }
}
