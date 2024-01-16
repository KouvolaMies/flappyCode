using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cammove : MonoBehaviour
{

    [SerializeField] private Transform playerpos;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(playerpos.position.x, transform.position.y, transform.position.z);
    }
}
