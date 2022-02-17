using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody playerRigidbody;
    bool movesForward;
    bool movesBack;

    float moveSpeed = 10;
    float rotateSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, 1, 0) * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -1, 0) * rotateSpeed * Time.deltaTime);
        }

        movesForward = Input.GetKey(KeyCode.UpArrow);
        movesBack = Input.GetKey(KeyCode.DownArrow);
    }

    private void FixedUpdate()
    {
        if (movesForward)
        {
            playerRigidbody.velocity = transform.forward * moveSpeed;
        }
        else if (movesBack)
        {
            playerRigidbody.velocity = -transform.forward * moveSpeed;
        }
        else
        {
            playerRigidbody.velocity = Vector3.zero;
        }
    }
}
