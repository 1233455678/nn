using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero2 : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;

    private void Aweke2()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update2()
    {
        if (Input.GetButton("Horizontal2"))
            Run2();
        if (Input.GetAxis("Horizontal2") != 0)
            Flip2();
    }

    private void Flip2()
    {
        if (Input.GetAxisRaw("Horizontal2") == 1)
        {
            transform.localScale = new Vector3(1, 1, 1);
        } else if (Input.GetAxisRaw("Horizontal2") == -1)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void Run2()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal2");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }
}
