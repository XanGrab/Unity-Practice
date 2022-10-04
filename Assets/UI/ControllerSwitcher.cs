using UnityEngine;
using Cinemachine;
#if ENABLE_INPUT_SYSTEM
using UnityEngine.InputSystem;
#else
Debug.LogError("New Unity Input System is required for the Character Inputs");
#endif

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class ControllerSwitcher : MonoBehaviour {

    public GameObject body;

    public void OnSwitch(InputValue value) { }

    enum states{
        FirstPerson,
        ThirdPerson
    }
}