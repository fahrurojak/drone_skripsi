using UnityEngine;

public class WindVisualEffect : MonoBehaviour
{
    private ParticleSystem ps;

    public void Init(Vector3 direction, float strength)
    {
        transform.rotation = Quaternion.LookRotation(direction);
        ps = GetComponent<ParticleSystem>();

        if (ps != null)
        {
            var main = ps.main;
            main.startSpeed = strength;
            ps.Play();
        }

        Destroy(gameObject, 2f);
    }
}
