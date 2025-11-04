using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private Transform playerLocation;
    [SerializeField] private bool isChasing;
    [SerializeField] private float speed;
    [SerializeField] private float minimumStopDistance = 0.1f;

    /*
    private void Start()
    {
        isChasing = true;
    }
    */

    private void Update()
    {
        if (isChasing)
        {
            Vector2 dir = playerLocation.position - transform.position;
            dir.Normalize();

            transform.Translate(dir * speed * Time.deltaTime);
        }
        else if ((isChasing &&
            Vector2.Distance(transform.position, playerLocation.position) < minimumStopDistance) ||
            !isChasing)
        {
            StopChasing();
        }
    }
    public void Chase()
    {
        isChasing = true;
    }

    public void StopChasing()
    {
        isChasing = false;
    }
}