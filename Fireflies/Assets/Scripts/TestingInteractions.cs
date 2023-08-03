using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingInteractions : MonoBehaviour
{
    [SerializeField] float direction = 1f;
    [SerializeField] Transform pt;
    Transform oldpt;
    // Start is called before the first frame update
    void Start()
    {
        oldpt = transform;
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = Vector3.MoveTowards(transform.position, pt.position, 5f * Time.deltaTime*direction);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Firefly")) 
        {
            Debug.Log("Trigger works:"+ gameObject.name+ " firefly");
            //transform.position = Vector3.MoveTowards(transform.position, pt.position, -5f * Time.deltaTime * direction);
        }
        else if (collision.CompareTag("Player"))
        {
            Debug.Log("Trigger works:" + gameObject.name + " player");
            //transform.position = Vector3.MoveTowards(transform.position, pt.position, -5f * Time.deltaTime * direction);
        }
        transform.position = Vector3.MoveTowards(transform.position, oldpt.position, 5f * Time.deltaTime * direction);
    }
    //private void OnCollisionEnter2D(Collision2D collision)//no collision happening
    //{
    //    if (collision.gameObject.CompareTag("Firefly"))
    //    {
    //        Debug.Log("Collision works:"+ gameObject.name + " firefly");
    //    }
    //    else if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Debug.Log("Collision works:" + gameObject.name + " player");
    //    }

    //}
}
