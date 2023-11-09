using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrapping : MonoBehaviour
{
    Animator animator;
    EnemyAI enemyAI;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();

    }
    public void OnTriggerEnter(Collider other)
    {
        if (animator.GetBool("Trap Active") == false)
        {

            Debug.Log("joebide");

            enemyAI = other.GetComponent<EnemyAI>();

            if (other.gameObject.tag == "Enemy")
            {
                    StartCoroutine(StartAnimation(10));
            }
        }

    }


    IEnumerator StartAnimation(float waitTime)
    {
        animator.SetBool("Trap Active", true);

        enemyAI.health -= 150;

        yield return new WaitForSeconds(waitTime);

        animator.SetBool("Trap Active", false);

        yield return null;
    }
}
