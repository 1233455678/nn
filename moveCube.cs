using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCube : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    private SpriteRenderer sprite;

    private void Aweke()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void Update()
    {
        if (Input.GetButton("Horizontal2"))
            Run();
    }

    private void Run()
    {
        Vector3 dir = transform.right * Input.GetAxis("Horizontal2");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);
    }
}