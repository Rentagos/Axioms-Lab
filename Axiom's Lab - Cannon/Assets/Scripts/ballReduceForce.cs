using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballReduceForce : MonoBehaviour
{
    public float reduceX = 0;
    public float reduceY = 0;
    public float reduceZ = 0;

    public float speed = 1.0f;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<ConstantForce>().force = new Vector3(reduceX, reduceY, reduceZ);

        if (reduceX > 0)
        {
            reduceX -= Time.deltaTime * 200;
        }

        if (reduceX < 0)
        {
            reduceX = 0;
        }

        if (reduceY > 0)
        {
            reduceY -= Time.deltaTime * 200;
        }

        if (reduceY < 0)
        {
            reduceY = 0;
        }

        if (reduceZ > 0)
        {
            reduceZ -= Time.deltaTime * 200;
        }

        if (reduceZ < 0)
        {
            reduceZ = 0;
        }


    }

}
