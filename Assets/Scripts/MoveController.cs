using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [Range(0f, 0.1f)] public float offset;

    void Start()
    {
    }

    private void Update()
    {
        CheckKeyPressedAndMove(KeyCode.Space, Vector3.up);
        CheckKeyPressedAndMove(KeyCode.LeftShift, Vector3.down);
        CheckKeyPressedAndMove(KeyCode.A, Vector3.left);
        CheckKeyPressedAndMove(KeyCode.D, Vector3.right);
        CheckKeyPressedAndMove(KeyCode.W, Vector3.forward);
        CheckKeyPressedAndMove(KeyCode.S, Vector3.back);
    }

    private void CheckKeyPressedAndMove(KeyCode keyCode, Vector3 direction)
    {
        var keyPressed = Input.GetKey(keyCode);

        if (keyPressed)
        {
            Move(direction);
        }
    }

    private void Move(Vector3 moveDelta)
    {
        transform.position = transform.position + offset * moveDelta;
    }
}