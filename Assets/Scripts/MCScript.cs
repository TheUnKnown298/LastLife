using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour


{
    public Rigidbody2D playerBody;
    public Player player;
    public float moveSpeed;
    private Vector2 targetLocation;
    private Vector2 moveDirection;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        targetLocation = transform.position;
        moveSpeed = 7;
    }

    void Update()
    {
        ProcessInput();
        transform.position = Vector3.MoveTowards(transform.position, targetLocation, moveSpeed * Time.deltaTime);

        if (Input.GetMouseButtonUp(0))
        {
            Stop();
        }
    }

    public void Stop()
    {
        targetLocation = transform.position;
    }

    void FixedUpdate()
    {
        GetPlayerTargetLocation();
    }

    void ProcessInput()
    {


        float moveX = Input.GetAxis("Mouse X");
        float moveY = Input.GetAxis("Mouse Y");

        if (Input.touchCount > 0)
        {
            moveX = Input.touches[0].deltaPosition.x;
            moveY = Input.touches[0].deltaPosition.y;
        }

        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void GetPlayerTargetLocation()
    {
        targetLocation += new Vector2(moveDirection.x, moveDirection.y);
    }
}
