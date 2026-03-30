using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private GameObject Character;
    [SerializeField] private Vector3 offset = new Vector3(0f, 10f, -6f);



    void Start()
    {
        transform.position = Character.transform.position + offset;
        transform.LookAt(Character.transform);        
    }

}
