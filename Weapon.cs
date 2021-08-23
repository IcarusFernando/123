using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{   
    public GameObject image ;
    public GameObject projectile;
    public float launch = 700f;
    // Start is called before the first frame update
    void Start()
    {
        image.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            GameObject bullet = Instantiate(projectile.transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().addRelativeForce(new Vector3(0, launch, 0));
            image.SetActive(false);
        }
    }
}
