using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectToPosition : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(10, 0, 0);
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}