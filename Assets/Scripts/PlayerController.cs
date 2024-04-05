using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D birdRb;
    [SerializeField] float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        birdRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            birdRb.AddForce(Vector2.up * jumpForce);
        }
        Debug.Log(birdRb.velocity);
    }
}
