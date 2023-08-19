using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SwipeDetection : MonoBehaviour
{
  public Player player;
  private Vector2 startPosition;
  public int dislocationThreshold = 20;
  private bool fingerDown;

  void Update()
  {
    if (fingerDown == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
    {
      fingerDown = true;
      startPosition = Input.touches[0].position;
    }

    if (fingerDown)
    {
      if (Input.touches[0].position.y >= startPosition.y + dislocationThreshold)
      {
        Debug.Log(Input.touches[0].position.y);
      }
    }
  }
}