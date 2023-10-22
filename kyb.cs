using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kyb : MonoBehaviour
{
    int health = 5; //hp
    int level = 1; //lvl
    float speed = 1.2f; //скорость
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print("Здоровье: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.z += speed * Time.deltaTime;

        transform.position = newPos;

    }
}
