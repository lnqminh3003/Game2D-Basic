using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSpawner : MonoBehaviour
{
    [SerializeField] Attack[] attack;
    bool spawn;
    Coroutine attaSpawn;
    private void Start()
    {
        spawn = true;
        attaSpawn = StartCoroutine(AttackSpawners());
    }
    IEnumerator AttackSpawners()
    {
        while (spawn)
        {
            int randomNumber = Random.Range(0, 2);
           var att =  Instantiate(attack[randomNumber], transform.position, Quaternion.identity);
            att.transform.parent = transform;
            

            float timeSpawnAttack = Random.Range(1f, 5f);
            yield return new WaitForSeconds(timeSpawnAttack);
        }
    }
    public void StopSpawner()
    {
        StopCoroutine(attaSpawn);
    }
}
