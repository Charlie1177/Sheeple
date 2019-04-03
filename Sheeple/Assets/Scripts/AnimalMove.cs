using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimalMove : MonoBehaviour
{
    
    //spped and other variables
    public float speed = 1.5f;
    private Vector3 target;
    private int moved = 0;

    void Start()
    {
        target = transform.position;
    }

    void Update()
    {
        {
            //check if the mouse button has been clicked
            if (Input.GetMouseButtonDown(0))
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = transform.position.z;
            }
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            
        }
        
    }
    
}