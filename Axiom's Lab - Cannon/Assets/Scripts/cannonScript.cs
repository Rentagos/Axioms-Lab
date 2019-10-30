using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cannonScript : MonoBehaviour
{

    public float rForceX = 0;
    public float rForceY = 0;
    public float rForceZ = 0;


    // Start is called before the first frame update
    void Start()
    {


    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ball"))
        {

            other.gameObject.GetComponent<ConstantForce>().force = new Vector3(rForceX, rForceY, rForceZ);

        }
    }

    public void sliderX(Slider slider)
    {
        rForceX = slider.value;
    }

    public void sliderY(Slider slider)
    {
        rForceY = slider.value;
    }

    public void sliderZ(Slider slider)
    {
        rForceZ = slider.value;
    }
}
