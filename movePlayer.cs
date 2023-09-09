using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private void Aweke()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetButton("Debug Horizontal"))
            Run();
        if (Input.GetAxis("Debug Horizontal") != 0)
            Flip();
    }

    private void Flip()
    {
        if (Input.GetAxisRaw("Debug Horizontal") == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
        } else if (Input.GetAxisRaw("Debug Horizontal") == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Debug Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }
}
