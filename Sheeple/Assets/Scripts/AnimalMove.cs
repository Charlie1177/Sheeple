using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AnimalMove : MonoBehaviour
{
    public float health = 100;
    private float realHealth = 100;
    [Header("Unity Stuff")]
    public Image healthbar;
    
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
            if (Input.GetMouseButtonDown(0))
            {
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = transform.position.z;
            }
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            
        }
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "pain")
            Debug.Log("Entered");
        float damage = 15;
        health = realHealth;
        health -= damage;
        realHealth = health;
        health = health / 100f;
        healthbar.fillAmount = health;
    }
}