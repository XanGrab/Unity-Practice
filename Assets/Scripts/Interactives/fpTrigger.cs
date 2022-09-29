using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fpTrigger : MonoBehaviour {
    // Update is called once per frame
    void OnTriggerEnter(Collider trig){
        collideTrigger ct = trig.transform.gameObject.GetComponent<collideTrigger>();
                if (ct != null) { ct.Activate(this.gameObject); }
    }
}
