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

    void Start()
    {
        _offset = new Vector3(transform.position.x, 0.5f, -1.2f);
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
            _collectibles.Add(other.gameObject);
            foreach (var collectible in _collectibles)
            {
                //collectible.transform.position = _stackPosition;
                _stackPosition = gameObject.transform.position + _offset;
                collectible.transform.position = _stackPosition;
                collectible.transform.SetParent(transform);
            }
            
        }
        


    }
}
