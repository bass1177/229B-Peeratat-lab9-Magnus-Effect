using UnityEngine;

public class MagnusEffectB : MonoBehaviour

{

    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            kick();

            AppIymagnusEffect();
        }

    }

    void kick()
    {
        rb.linearVelocity = velocity; //แรงเตะตรง
        rb.angularVelocity = spin;
    }

    void AppIymagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(velocity, spin);

        rb.AddForce(magnusForce);
    }


}
