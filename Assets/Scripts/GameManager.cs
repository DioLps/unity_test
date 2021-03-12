using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject hazardPrefab;
    public int maxHazardsToSpawn = 3;

    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(SpawnHazards()); 
    }


    private IEnumerator SpawnHazards()
    {
        var hazardsToSpawn = Random.Range(1, maxHazardsToSpawn);

        for (int i = 0; i < hazardsToSpawn; i++)
        {
            SpawnHazard();
        }

        yield return new WaitForSeconds(1f);

        yield return SpawnHazards();
    }


    private GameObject SpawnHazard()
    {
        var x = Random.Range(-7, 7); 
        var drag = Random.Range(0f, 2f);

        var hazard = Instantiate(hazardPrefab, new Vector3(x, 11, 0), hazardPrefab.transform.rotation);
        hazard.GetComponent<Rigidbody>().drag = drag;

        return hazard; 
    }

}
