using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Controls input;

    private void Start()
    {
        input = new Controls();
        input.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        print(input.Character.Movement.ReadValue<Vector2>());
    }
}
