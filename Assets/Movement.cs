using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 2f;
    public Transform cameraTransform;
    public Transform targetTransformA;

    public Transform targetTransformB;
    public Vector3 velocity;

    public float step = 0.01f;

    private float interpolantValue = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    /*
        Movement: 
            We were trying to create movement programatically.
            We had two main concepts called local space and world space.
            World space its the same for all game objects meanwhile local space will change 
            with the rotation, position, etc.

            So we can add to the transform.position vectors and create movement in the two
            spaces (local and world).
            By adding Vector3 to transform.position it will move in world space
            but if we add instead of a Vector3 a propertiy of transform called transform.forward 
            this will use the local position, so we are adding vectors in both ways but one its using
            local position.
    */
    // Update is called once per frame
    void Update()
    {
        // This is moving in world space position.
        //transform.position += new Vector3(0, 0, 1) * Time.deltaTime;

        // This will move the object in local space one unit at a time.
        //transform.Translate(Vector3.forward * Time.deltaTime);

        // Moving with input and adding speed
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        /*var movement = new Vector3(x, 0 , y);
        movement = Vector3.ClampMagnitude(movement, 1);
        transform.Translate(movement * speed * Time.deltaTime);*/

        // Moving related to another object.
        /*var direction = (transform.position - cameraTransform.position ).normalized;
        var movement = new Vector3(x * direction.z , 0, y * direction.z);
        movement = Vector3.ClampMagnitude(movement, 1);
        transform.Translate(movement  * speed * Time.deltaTime, Space.World);*/

        // Moving to a specific target manually
        /*var distVector = (targetTransformA.position - transform.position);
        if (distVector.magnitude >= 0.7f)
        {
            var direction = distVector.normalized;
            var changedDir = new Vector3(direction.x, 0, direction.z).normalized;
            transform.Translate(changedDir * speed * Time.deltaTime, Space.World);
        }*/
       
        // This line below does it automatically but with not much control.
        //transform.position = Vector3.SmoothDamp(transform.position, targetTransformA.position, ref velocity, 5f, 10f);


        // Using Lerp to move an object between another two objects at a step speed
        /*if(interpolantValue > 1f || interpolantValue < 0f){
            step*=-1;
        }
        interpolantValue+= step * Time.deltaTime;
        var lerp = Vector3.Lerp(targetTransformA.position, targetTransformB.position, interpolantValue);
        var newPosition = new Vector3(lerp.x, transform.position.y, lerp.z);
        transform.position = newPosition;*/

        // Adding force to an object.
        // We first need to assign a rigid body, then the forces can be applied wether as an impulse or being continuous
    }
}
