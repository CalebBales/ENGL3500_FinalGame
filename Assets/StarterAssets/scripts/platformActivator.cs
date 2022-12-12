using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformActivator : MonoBehaviour
{
[SerializeField] GameObject objectToActivate;
[SerializeField] GameObject objectToActivate_two;

    // Start is called before the first frame update
    void Start()
    {
       objectToActivate.GetComponent<movePlatform>().enabled = true;
       objectToActivate_two.GetComponent<movePlatform>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        objectToActivate.GetComponent<movePlatform>().enabled = false;
        objectToActivate_two.GetComponent<movePlatform>().enabled = false;
    }
}
