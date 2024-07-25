using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _runSpeed;
    private Controlls control;

    void Start()
    {
        control = new Controlls();
        control.Enable();
    }

    private void Update()
    {
        Vector2 moveDirection = control.Player.Move.ReadValue<Vector2>();
        Vector3 movement = new Vector3(moveDirection.x, 0, moveDirection.y);
        transform.Translate(movement * _speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.Translate(movement * _runSpeed * Time.deltaTime);
        }
    }
}
