using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player : MonoBehaviour
{
    Rigidbody2D rb;
    float xinput;
    public float speed;
    Vector2 xposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        MovePlayer();
    }
    void MovePlayer()
    {
        //xinput = Input.GetAxis("Horizontal");
        xinput = CrossPlatformInputManager.GetAxis("Horizontal");
        xposition = transform.position;
        xposition.x += xinput * speed;
        //xinput = Mathf.Clamp(xinput, -1.8f, 1.8f);
        //rb.velocity = new Vector2(xposition.x, 0f);
        //xposition = transform.position;
        //xposition.x += xinput*speed;
        xposition.x = Mathf.Clamp(xposition.x, -2f, 2f);
        rb.MovePosition(xposition);
    }
}
