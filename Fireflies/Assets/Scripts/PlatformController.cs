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

    }

    void FixedUpdate()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("is Object triggering");
        if (collision.tag== "Firefly")
        {
            oldPt = transform.position;
            transform.position = Vector3.MoveTowards(transform.position,platPoint.position,spdPlat *Time.fixedDeltaTime);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("is object exiting trigger");
        transform.position = Vector3.MoveTowards(transform.position, oldPt, spdPlat * Time.fixedDeltaTime);
    }
}
