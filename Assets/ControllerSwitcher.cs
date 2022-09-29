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

    public CinemachineVirtualCamera m_CinemachineCamFirstPerson;
    public CinemachineVirtualCamera m_CinemachineCamThirtPerson;

    public GameObject body;

    public void OnSwitch(InputValue value) {
        GameObject FPCamera = m_CinemachineCamFirstPerson.GameObject;
        GameObject ThirdPCamera = m_CinemachineCamThirdPerson.GameObject;

        FPCamera.SetActive(!FPCamera.activeInHierarchy);
        ThirdPCamera.SetActive(!ThirdPCamera.activeInHierarchy);
    }
}