using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralScript : MonoBehaviour
{
    private bool fingerDown;
    private Vector2 startPosition;
    public Player player;
    private Vector2 moveDirection;

    void Start()
    {

    }

    void Update()
    {
        // if (fingerDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        // {
        //     fingerDown = true;
        //     startPosition = Input.touches[0].position;
        // }

        // if (fingerDown)
        // {
        //     // Debug.Log(Vector2.Angle(Input.touches[0].position, startPosition));
        //     // Debug.Log(Input.GetAxisRaw("Vertical"));
        //     // player.Move(new Vector2(Input.touches[0].position.x - startPosition.x, Input.touches[0].position.y - startPosition.y));
        //     // player.Move(new Vector2(Input.touches[0].position.x, Input.touches[0].position.y));
        //     // player.Move(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized);

        //     if (Input.GetMouseButtonUp(0))
        //     {
        //         fingerDown = false;
        //         player.StopMoving(new Vector2(0, 0));
        //     }
        // }
    }
}