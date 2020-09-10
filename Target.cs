using UnityEngine;

public class Target : MonoBehaviour
{
    public int targetsHit;

    public void Die()
    {
        Destroy(gameObject);
    }
}