using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpForce : MonoBehaviour
{
    public float jumpForce; // Сила прыжка
    private bool isGrounded; // Переменная, которая определяет, на земле ли игрок
    public Transform groundCheck; // Transform, который будет проверять, на земле ли игрок
    public float checkRadius; // Радиус проверки земли
    public LayerMask whatIsGround; // Слой, на котором находится земля

    void OnCollisionEnter2D(Collision2D other) // Задает условие, при котором игрок соприкасается с землей
    {
        if (other.gameObject.CompareTag("Ground"))
            {
                isGrounded = true;
            }
    }

void Update() // Обновляет скрипт каждый кадр
    {
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space)) // Проверяет, на земле ли игрок и была ли нажата кнопка прыжка
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpForce); // Дает игроку силу для прыжка
            }
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround); // Проверяет, был ли игрок на земле в предыдущем кадре
    }
}