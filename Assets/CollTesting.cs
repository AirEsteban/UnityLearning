using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollTesting : MonoBehaviour
{
    [SerializeField]
    private int magnitude = 2;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag.Equals("Player")){
            var direction = (this.gameObject.transform.position - other.transform.position).normalized;
            this.gameObject.GetComponent<Rigidbody>().AddForce( direction * magnitude, ForceMode.Impulse);
        }
    }
}
