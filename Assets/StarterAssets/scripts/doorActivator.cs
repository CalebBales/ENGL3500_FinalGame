using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorActivator : MonoBehaviour
{
[SerializeField] GameObject objectToActivate;
[SerializeField] GameObject objectToActivate_two;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other){
        // objectToActivate.GetComponent<doorCloser>().enabled = false;
        // objectToActivate_two.GetComponent<doorCloser>().enabled = false;

        objectToActivate.GetComponent<doorOpener>().enabled = true;
        objectToActivate_two.GetComponent<doorOpener>().enabled = true;
    }

    private void OnTriggerExit(Collider other){

        // objectToActivate.GetComponent<doorOpener>().enabled = false;
        // objectToActivate_two.GetComponent<doorOpener>().enabled = false;

        objectToActivate.GetComponent<doorCloser>().enabled = true;
        objectToActivate_two.GetComponent<doorCloser>().enabled = true;

    }
}
