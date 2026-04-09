using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour
{
    [SerializeField] private float moveSpeed=5f;
    [SerializeField] private GameObject DetechCube;

    private CharacterController controller;
    private int maxCount = 10;
    private int Count = 0;


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        SmallRock.OnSmallRockCollected +=;
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 moveDir = new Vector3(h,0f,v);

        if (moveDir.sqrMagnitude > 1f) moveDir.Normalize();

        controller.Move(moveDir*moveSpeed*Time.deltaTime);
    }

}
