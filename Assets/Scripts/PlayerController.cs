using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement; //add this with all the other “using”s on top


public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed, maxForce;
    private Vector2 move;
    
    public void OnMove(InputAction.CallbackContext context)
    {
        move = context.ReadValue<Vector2>();
    }

    private void FixedUpdate() {
        //Find target velocity
        Vector3 currVelocity = rb.velocity;
        Vector3 targetVelocity = new Vector3(move.x, 0, move.y);
        targetVelocity *= speed;

        //Align direction
        targetVelocity = transform.TransformDirection(targetVelocity);

        //Calculate forces
        Vector3 velocityChange = targetVelocity - currVelocity;

        rb.AddForce(velocityChange, ForceMode.VelocityChange);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
        if((Input.GetKey(KeyCode.R)) && (Input.GetKey(KeyCode.Equals)))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
