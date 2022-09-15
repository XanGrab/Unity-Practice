using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpStrafe : MonoBehaviour
{
    [SerializeField] private float strafeSpeed = 3f;
    [SerializeField] private CharacterController charCtrl;

    void Start()
    {
        // cc = gameObject.GetComponent<CharacterController>();
        if (charCtrl==null){Debug.LogError("Missing CharacterController");}
    }
    // Update is called once per frame
    void Update()
    {
        float strafeDir = 0;
        if(Input.GetAxis("Horizontal") < -0.1f){
            strafeDir = -1;
        }
        else if (Input.GetAxis("Horizontal") > 0.1f){
            strafeDir = 1;
        }
        float strafe = strafeDir * strafeSpeed;
        charCtrl.Move((transform.right * strafe) * Time.deltaTime);
    }
}
