using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Horizontal;
    public float Vertical;
    public float velocityH;
    public float velocityV;
   
    private Rigidbody2D _body2D;
    private SpriteRenderer _renderer;
    void Awake()
    {
        _renderer = GetComponent<SpriteRenderer>();
        _body2D = GetComponent<Rigidbody2D>();

    }
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");
    }
    void FixedUpdate()
    {
        _body2D.velocity = new Vector2(Horizontal * velocityH * Time.deltaTime, Vertical * velocityV * Time.deltaTime);
    }
}
