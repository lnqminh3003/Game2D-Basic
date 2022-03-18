using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject completedLevel;
    [SerializeField] GameObject youLoseCanvas;
   
    [SerializeField] AudioClip a;
    AttackSpawner []arrayAttackSpawner;
   
    
    private void Start()
    {
        
        arrayAttackSpawner = FindObjectsOfType<AttackSpawner>();
    }
    public void AttackKilled()
    {
        if (ListenTimeZero() && CountAttack() == 1)
        {
            StartCoroutine(LoadNextLevel());
        }
    }
    IEnumerator LoadNextLevel()
    {
     
        completedLevel.SetActive(true);
        AudioSource.PlayClipAtPoint(a, Camera.main.transform.position);

        yield return new WaitForSeconds(4f);

        FindObjectOfType<LoadLevel>().LoadNextLevel();
    }
    private int CountAttack()
    {
        int sumAttack = 0;
        foreach(AttackSpawner i in arrayAttackSpawner)
        {
            sumAttack += i.transform.childCount;
        }
        return sumAttack;
    }
    private bool ListenTimeZero()
    {
        Timer timer = FindObjectOfType<Timer>();
        if (timer.CheckTimeZero())
        {
      
            foreach (AttackSpawner i in arrayAttackSpawner)
            {
                i.StopSpawner();

            }
            return true;
        }
        return false;
    }

    //LoseController
    public void ActiveYouLoseCanvas()
    {
        youLoseCanvas.SetActive(true);
    }
   
}
