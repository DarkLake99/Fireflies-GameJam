using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] Transform platPoint;
    [SerializeField] Transform platPointOrg;
    [SerializeField] bool movePlat;
    //[SerializeField] bool fireflyLike;//optional code to create platforms that closes when fireflies are near
    [SerializeField] float spdPlat = 5f;
    public Fireflies fly;
    bool trigMoveEnter = false;
    bool trigMoveExit = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if ( trigMoveEnter && movePlat) 
        {
            transform.position = Vector3.MoveTowards(transform.position, platPoint.position, spdPlat * Time.deltaTime);
        }
        else if(!trigMoveEnter && movePlat)
        {
            //Debug.Log("did it exit properly? & oldPt: "+ platPointOrg.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, platPointOrg.position, spdPlat * Time.deltaTime);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("is platform triggering?");
        if (collision.gameObject.tag == "Firefly")
        {
            Debug.Log("entered trigger state by firefly frm plat");
            trigMoveEnter = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Firefly")
        {
            //Debug.Log("exit plat trigger by firefly");
            trigMoveEnter = false;
        }
    }
}
