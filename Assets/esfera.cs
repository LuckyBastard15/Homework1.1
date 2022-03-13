using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esfera : MonoBehaviour
{
    [SerializeField] private Light _light;
    [SerializeField] private GameObject _sphere;

    void Start()
    {
        GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    private void OnTriggerEnter(Collider other)
    {
        _light.color = GetComponent<Renderer>().material.color;
    }

    private void OnTriggerExit(Collider other)
    {
        _light.color = Color.white;
    }
}
