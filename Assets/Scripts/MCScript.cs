using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MCScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D playerBody;
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
