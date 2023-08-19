using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralScript : MonoBehaviour
{
    private bool fingerDown;
    private Vector2 startPosition;
    public Player player;

    void Start()
    {

    }

    void Update()
    {
        if (fingerDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            fingerDown = true;
            startPosition = Input.touches[0].position;
        }

        if (fingerDown)
        {
            Debug.Log(Vector2.Angle(Input.touches[0].position, startPosition));
            player.Move(new Vector2(Input.touches[0].position.x - startPosition.x, Input.touches[0].position.y - startPosition.y));
            if (Input.GetMouseButtonUp(0))
            {
                Debug.Log("lasdlasldasld");
                fingerDown = false;
                player.Stop(new Vector2(0, 0));
            }
        }
    }
}