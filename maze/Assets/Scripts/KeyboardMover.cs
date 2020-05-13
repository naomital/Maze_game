using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */
public class KeyboardMover: MonoBehaviour {
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;
    Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update() {

        if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
            animator.SetBool("isWalking", true);
            

        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
            animator.SetBool("isWalking", true);

        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, speed * Time.deltaTime, 0);
            animator.SetBool("isWalking", true);

        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -speed * Time.deltaTime, 0);
            animator.SetBool("isWalking", true);

        }
        else
        {
            animator.SetBool("isWalking", false);

        }
    }
}
