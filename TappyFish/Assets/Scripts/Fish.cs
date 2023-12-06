using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        //_rb.gravityScale = 0;
        _rb.velocity = new Vector2(_rb.velocity.x, 9f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
