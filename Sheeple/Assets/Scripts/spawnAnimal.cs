using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Notes: Object to spawn can be selected from Unity Inspector. Attach to Camera.

public class spawnAnimal : MonoBehaviour
{
    bool isSelected;
    bool isEnough;
    bool smallSpawn;
    bool medSpawn;
    bool largeSpawn;
    public GameObject objectToSpawn;
    public GameObject updateMoney;
    public GameObject checkMoney;


    //public Sprite sprite;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(checkMoney.GetComponent<Money>().money < 30 && checkMoney.GetComponent<Money>().money >= 20)
        {
            isEnough = true;
            largeSpawn = false;
            medSpawn = true;
            smallSpawn = true;
            
        }else if(checkMoney.GetComponent<Money>().money < 20 && checkMoney.GetComponent<Money>().money >= 10)
        {
            isEnough = true;
            largeSpawn = false;
            medSpawn = false;
            smallSpawn = true;
            return;

        }else if(checkMoney.GetComponent<Money>().money < 10)
        {
            isEnough = false;
            largeSpawn = false;
            medSpawn = false;
            smallSpawn = false;
            return;
        }
        else
        {
            isEnough = true;
            largeSpawn = true;
            medSpawn = true;
            smallSpawn = true;
        }
        if (isEnough)
        {

            if (isSelected)
            {

                if (Input.GetMouseButtonDown(0))
                {
                
                    
                    Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    spawnPosition.z = 0.0f;
                    GameObject objectInstance = Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                    isSelected = false;

                    if (largeSpawn == true)
                    {
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
                    } else if (largeSpawn == false && medSpawn == true)
                    {
                        switch (objectInstance.name.Substring(0, 4))
                        {
                            case "cana":
                                updateMoney.GetComponent<Money>().money -= 10;
                                break;
                            case "dogS":
                                updateMoney.GetComponent<Money>().money -= 20;
                                break;
                        }
                    }else if (medSpawn == false && smallSpawn == true){
                        switch (objectInstance.name.Substring(0, 4))
                        {
                            case "cana":
                                updateMoney.GetComponent<Money>().money -= 10;
                                break;
                        }
                    }
                    
                }
            
            }
        }
        
    }

    public void Selecting()
    {
        isSelected = !isSelected;
    }

}
