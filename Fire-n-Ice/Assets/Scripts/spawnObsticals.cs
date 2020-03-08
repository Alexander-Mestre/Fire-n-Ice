using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawnObsticals : MonoBehaviour
{
    public Obstical obs_1;
    public Obstical obs_2;
    public GameObject spawner;
    public float spawnTime = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(wave());
        
        //look for our player object to get our z point
        spawner = GameObject.Find("FPSController");
    }

    private void spawnObstical()
    {
        //spawn object
        Obstical a = Instantiate(obs_1) as Obstical;

        //set its location to our spawner 
        a.transform.position = new Vector3(Random.Range(-4,4),Random.Range(2,5),spawner.transform.position.z + 20);
    }

    IEnumerator wave()
    {
        while(true)
        {
            yield return new WaitForSeconds(spawnTime);
            spawnObstical();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
