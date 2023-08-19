using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour


{
    private Rigidbody2D playerBody;
    public Player player;
    public float moveSpeed;
    private Vector3 targetLocation;

    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
        targetLocation = transform.position;
        moveSpeed = 5;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetLocation, moveSpeed * Time.deltaTime);
    }

    public void Move(Vector3 moveDirection)
    {
        targetLocation += moveDirection;
    }

    public void Stop(Vector3 moveDirection)
    {
        targetLocation = transform.position;
    }
}
