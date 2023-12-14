using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodController : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        StartCoroutine(destroy());
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0,0,1);
    }

    private IEnumerator destroy(){
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
