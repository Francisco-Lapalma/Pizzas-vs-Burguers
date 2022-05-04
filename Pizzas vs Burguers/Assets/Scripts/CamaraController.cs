using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private GameObject seePoint;
    private Vector3 distance;

    void Start()
    {
        distance = transform.position - seePoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = seePoint.transform.position + distance; 
    }
}
