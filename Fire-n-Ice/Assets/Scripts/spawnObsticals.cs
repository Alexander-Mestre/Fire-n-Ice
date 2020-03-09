using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawnObsticals : MonoBehaviour
{
    public Obstical obs_1;//ice_1
    public Obstical obs_2;//ice_2
    public Obstical obs_3;//fire_1
    public Obstical obs_4;//fire_2

    
    public GameObject player;
    public Transform levelRotator;

    public GameObject spawner;
    public float spawnTime = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        //get our player
        player = GameObject.Find("FPSController");
        StartCoroutine(wave());
        
    }

    private void spawnObstical()
    {
        //randomely pick between fire and ice obsticals
        int fireOrice = Random.Range(1,4);

        if(fireOrice == 1)
        {
            //spawn ice
            Obstical newObstical = Instantiate(obs_1) as Obstical;
            newObstical.transform.position = new Vector3(Random.Range(-4,4),Random.Range(2,5),spawner.transform.position.z);

            //set parent to level rotator NOTE: false means it keeps its local orientation
            obs_1.transform.SetParent(levelRotator);
        }

        else if(fireOrice == 2)
        {
            //spawn ice_2
            Obstical newObstical = Instantiate(obs_2) as Obstical;
            newObstical.transform.position = new Vector3(Random.Range(-4,4),Random.Range(2,5),spawner.transform.position.z);

            //set parent to level rotator NOTE: false means it keeps its local orientation
            obs_2.transform.SetParent(levelRotator);
        }

         else if(fireOrice == 3)
        {
            //spawn fire_1
            Obstical newObstical = Instantiate(obs_3) as Obstical;
            newObstical.transform.position = new Vector3(Random.Range(-4,4),Random.Range(2,5),spawner.transform.position.z);

            //set parent to level rotator NOTE: false means it keeps its local orientation
            obs_3.transform.SetParent(levelRotator);
        }

         else if(fireOrice == 4)
        {
            //spawn fire_2
            Obstical newObstical = Instantiate(obs_4) as Obstical;
             //set its location to our spawner 
            newObstical.transform.position = new Vector3(Random.Range(-4,4),Random.Range(2,5),spawner.transform.position.z);

            //set parent to level rotator NOTE: false means it keeps its local orientation
            obs_4.transform.SetParent(levelRotator);
        }
    
    }

    IEnumerator wave()
    {
        //while game is running
        while(true)
        {
            yield return new WaitForSeconds(spawnTime);

            //update spawner position
            spawner.transform.position = new Vector3(transform.position.x,transform.position.y,player.transform.position.z +35);

            //spawn a new obstical
            spawnObstical();

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
