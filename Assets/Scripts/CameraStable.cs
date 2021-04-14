using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour
{
    public GameObject TheCar;
    public float CarX;
    public float CarY;
    public float CarZ;
    public float damper;
    
    private Vector3 velocity = Vector3.zero;
    public Vector3 initial;
    public Vector3 offset;

    private void Start()
    {
        //transform.eulerAngles = new Vector3(TheCar.transform.eulerAngles.x, TheCar.transform.eulerAngles.y, TheCar.transform.eulerAngles.z);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        CarX = TheCar.transform.eulerAngles.x;
        CarY = TheCar.transform.eulerAngles.y;
        CarZ = TheCar.transform.eulerAngles.z;

        //initial = new Vector3(CarX, CarY, CarZ);
        //offset = new Vector3(0, CarY, 0);
        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
        //transform.eulerAngles = Vector3.SmoothDamp(transform.eulerAngles, transform.eulerAngles + offset, ref velocity, damper * Time.deltaTime);
    }
}
