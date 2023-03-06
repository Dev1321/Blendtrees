using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private Animator animator;

    private float maximumSpeed;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float vertcalInput = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontalInput, 0, vertcalInput);
        float Blend = Mathf.Clamp01(movementDirection.magnitude);
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            Blend *= 3;
        }
        animator.SetFloat("Blend",Blend);
        float speed = Blend * maximumSpeed;
        movementDirection.Normalize();
     
    }
}
