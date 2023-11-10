using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrapping : MonoBehaviour
{
    Animator animator;
    EnemyAI enemyAI;
    bool doDamage = true;
    public AudioSource mouseSound;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (doDamage)
        {

            Debug.Log("joebide");

            enemyAI = other.GetComponent<EnemyAI>();

            if (other.gameObject.tag == "Enemy")
            {
                    StartCoroutine(StartAnimation(1, 9));
            }
        }
    }
    IEnumerator StartAnimation(float waitTime, float waitTimeDamage)
    {
        animator.SetBool("Trap Active", true);

        mouseSound.Play();

        enemyAI.health -= 150;

        doDamage = false;

        yield return new WaitForSeconds(waitTime);

        animator.SetBool("Trap Active", false);
        yield return new WaitForSeconds(waitTimeDamage);

        doDamage = true;

        yield return null;
    }
}
