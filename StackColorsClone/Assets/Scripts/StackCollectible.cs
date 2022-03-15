using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StackCollectible : MonoBehaviour
{
    // Start is called before the first frame update
    private List<GameObject> _collectibles;
    private Vector3 _stackPosition;
    private Vector3 _offset;
    private float _offsetY = 0.5f;

    void Start()
    {
        _collectibles = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectible"))
        {
            _offset = new Vector3(0, _offsetY, 0);
            _collectibles.Add(other.gameObject);
            //collectible.transform.position = _stackPosition;
            _stackPosition = gameObject.transform.position + _offset;
            other.transform.position = _stackPosition;
            other.transform.SetParent(transform);
            _offsetY += 0.6f;
        }
    }
}