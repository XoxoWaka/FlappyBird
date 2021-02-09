using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject colone;
    [SerializeField] private Vector2 vector;
    [SerializeField] private float randY;
    [SerializeField] private bool beforeColoneSpawn;


    private void Update()
    {
        if (beforeColoneSpawn)
        {
            StartCoroutine(ColoneSPawn());
            beforeColoneSpawn = false;
        }
        
    }
        
    IEnumerator ColoneSPawn()
    {        
        yield return new WaitForSeconds(1f);
        beforeColoneSpawn = true;
        randY = Random.Range(-2, 2);
        vector = new Vector2(transform.position.x, randY);
        Instantiate(colone, vector, Quaternion.identity);
        yield break;       
    }
}
