using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW1 : MonoBehaviour
{
    string hero = ("mohamed");
    int health = 100;
    int damaged_health;
    


    // Start is called before the first frame update
    void Start()
    {

        damaged_health = damaged();
        print("damaged health is " + damaged_health);
        print("boosted health is " + boost());

        if(boost() > damaged_health)
        {
            print(boost() );
        }
        else if(boost() == damaged_health)
        {
            print(boost() + "=" + damaged_health);
        }
        else
        {
            print(damaged_health);
        }
        print("80 is less than 90");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int damaged()
    {
     return   health - 20;
        
    } 

    int boost()
    {
        return damaged_health + 10;
    }
    
  
   
}
