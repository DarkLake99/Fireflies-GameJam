using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] Transform platPoint;
    [SerializeField] bool movePlat;
    [SerializeField] bool fireflyLike;//optional code to create platforms that closes when fireflies are near
    [SerializeField] float spdPlat = 20f;
    public Fireflies fly;
    private Vector3 oldPt;
    
    // Start is called before the first frame update
    void Start()
    {
        oldPt = transform.position;
    }

    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("is Object triggering???");
        if (collision.gameObject.tag == "Firefly")
        {
            Debug.Log("entered trigger state");
            transform.position = Vector3.MoveTowards(oldPt, platPoint.position, spdPlat * Time.deltaTime);
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Firefly")
        {
            Debug.Log("is object exiting collision");
            transform.position = Vector3.MoveTowards(platPoint.position, oldPt, spdPlat * Time.deltaTime);
        }
    }
}
