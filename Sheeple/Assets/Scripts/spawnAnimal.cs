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
        isSelected = false;
        isEnough = false;
        smallSpawn = false;
        medSpawn = false;
        largeSpawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(checkMoney.GetComponent<Money>().money < 10)
        {
            isEnough = false;
            largeSpawn = false;
            medSpawn = false;
            smallSpawn = false;
        }
        else
        {
            isEnough = true;
            smallSpawn = true;
            if (checkMoney.GetComponent<Money>().money > 20)
                medSpawn = true;
            if (checkMoney.GetComponent<Money>().money > 30)
                largeSpawn = true;
        }

        if (isEnough && isSelected)
        {

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 spawnPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                spawnPosition.z = 1;
                GameObject objectInstance = Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));

                switch (objectInstance.name.Substring(0, 4))
                {
                    case "cana":
                        if (smallSpawn)
                        {
                            updateMoney.GetComponent<Money>().money -= 10;
                            //objectInstance = Instantiate(GameObject.Find("canary"), spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                            isSelected = false;
                        }
                        else
                            DestroyImmediate(objectInstance);
                        break;
                    case "dogS":
                        if (medSpawn)
                        {
                            updateMoney.GetComponent<Money>().money -= 20;
                            //objectInstance = Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                            isSelected = false;
                        }
                        else
                            DestroyImmediate(objectInstance);
                        break;
                    case "cowS":
                        if (largeSpawn)
                        {
                            updateMoney.GetComponent<Money>().money -= 30;
                            //objectInstance = Instantiate(objectToSpawn, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0)));
                            isSelected = false;
                        }
                        else
                            DestroyImmediate(objectInstance);
                        break;
                }
            }
        }
        
    }
    private void LateUpdate()
    {
        isEnough = false;
        smallSpawn = false;
        medSpawn = false;
        largeSpawn = false;

    }

    public void Selecting()
    {
        isSelected = !isSelected;
    }

}
