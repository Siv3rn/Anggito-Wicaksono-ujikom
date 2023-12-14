using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed;
    [SerializeField] private GameObject food;
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveZ = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        transform.Translate(moveZ,0,0);
        if (moveZ > 0)
        {
            anim.SetBool("isRight",true);
            anim.SetFloat("Speed",speed);
        
        }
        else if (moveZ < 0)
        {
            anim.SetBool("isLeft",true);
            anim.SetFloat("Speed",speed);
        
        }
        else
        {
            anim.SetBool("isLeft",false);
            anim.SetBool("isRight",false);

            anim.SetFloat("Speed",0);
        }


        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("test");
            Instantiate(food,new Vector3(transform.position.x,2.45f,transform.position.z),transform.rotation);
            
        }
        
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log("bisa");
    }
}
