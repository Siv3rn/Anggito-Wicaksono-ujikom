using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class CowController : MonoBehaviour
{

    // Start is called before the first frame update
    public float health;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,1 * Time.deltaTime * 2);
        if (transform.position.z == 51)
        {
            Destroy(gameObject);
        }
    }
    public void die(){
        Destroy(gameObject);
    }
    private void OnCollisionEnter(Collision other) {
            die();
            Debug.Log("testing");
        
    }
    private void OnTriggerEnter(Collider other) {

            die();
        
    }

}
