using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMelee : MonoBehaviour
{
    [SerializeField] private float hitDistance; 
    private bool hasHitPlayer = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasHitPlayer)
        {
            Vector3 directionToPlayer = (collision.transform.position - transform.position).normalized;
            Vector3 hitPosition = collision.transform.position + directionToPlayer * hitDistance;

            StartCoroutine(MoveToPosition(hitPosition));

            hasHitPlayer = true;

            StartCoroutine(ResetHitStatus());
        }
    }

    IEnumerator MoveToPosition(Vector3 targetPosition)
    {
        float elapsedTime = 0f;
        float moveTime = 0.5f;

        Vector3 startPosition = transform.position;
        while (elapsedTime < moveTime)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, elapsedTime / moveTime);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }

    IEnumerator ResetHitStatus()
    {
        yield return new WaitForSeconds(1f); 
        hasHitPlayer = false; 
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, hitDistance);
    }
}
