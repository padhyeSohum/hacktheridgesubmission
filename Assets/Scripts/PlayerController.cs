using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D body;

    float horizontal;
    float vertical;

    public float runSpeed = 20.0f;

    public Sprite spriteW; // Drag your sprite for W in the inspector
    public Sprite spriteA; // Drag your sprite for A in the inspector
    public Sprite spriteS; // Drag your sprite for S in the inspector
    public Sprite spriteD; // Drag your sprite for D in the inspector

    SpriteRenderer spriteRenderer;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        // Check for input and change sprite accordingly
        if (Input.GetKey(KeyCode.W))
        {
            spriteRenderer.sprite = spriteW;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            spriteRenderer.sprite = spriteA;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            spriteRenderer.sprite = spriteS;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            spriteRenderer.sprite = spriteD;
        }

        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("Battle");
    }

    private void FixedUpdate()
    {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
}