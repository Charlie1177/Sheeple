using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Notes: Object to spawn can be selected from Unity Inspector. Attach to Camera.

public class spawnAnimal : MonoBehaviour
{
    bool isSelected;
    public GameObject objectToSpawn;
    public GameObject updateMoney;
    //public Sprite sprite;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (isSelected)
        {

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                spawnPosition.z = 0.0f;
                GameObject objectInstance = Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                isSelected = false;
                
                switch (objectInstance.name.Substring(0, 4))
                {
                    case "cana":
                        updateMoney.GetComponent<Money>().money -= 10;
                        break;
                    case "dogS":
                        updateMoney.GetComponent<Money>().money -= 20;
                        break;
                    case "cowS":
                        updateMoney.GetComponent<Money>().money -= 30;
                        break;

                }



            }
        }
        
    }

    public void Selecting()
    {
        isSelected = !isSelected;
    }

}
