using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    GameObject pickableObject;

    public GameObject PickableObject {get {return pickableObject;}}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        pickableObject = other.gameObject;

    }
    
}
