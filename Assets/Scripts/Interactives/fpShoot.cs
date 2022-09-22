using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
                    
public class fpShoot : MonoBehaviour {

    public enum Shot {nothing, createObject};
    [SerializeField] private Shot shot = Shot.nothing;
    [SerializeField] private GameObject spawnObject;
    private Camera cam;   
    Vector3 screenCenter = new Vector3(Screen.width/2, Screen.height/2, 0);
    private InputAction click;
                    
    void Awake() {
        cam = Camera.main;
        click = new InputAction(binding: "<Mouse>/leftButton");

        click.performed += ctx => {
            // Vector3 coords = Mouse.current.position.ReadValue();
            // Debug.Log($"[Debug] I clicked: {coords}");

            Ray ray = cam.ScreenPointToRay(screenCenter);
            onShoot(ray);
        };
        
        click.Enable();
    }                    

    void onShoot(Ray ray) {
        RaycastHit hit;
        if(Physics.Raycast(ray.origin,ray.direction, out hit)) {
            hitTrigger hitTrigger = hit.transform.gameObject.GetComponent<hitTrigger>();
            if (hitTrigger != null) {
                hitTrigger.Activate(ray, hit);
            }
        }

        if(shot == Shot.createObject) {
            GameObject spawn;
            if(spawnObject == null) {
                spawn = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            } else {
                spawn = GameObject.Instantiate(spawnObject);
            }
            spawn.transform.position = hit.point;
        }
    }
}
