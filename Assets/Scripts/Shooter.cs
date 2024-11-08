using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    [SerializeField] GameObject bullet;
    [SerializeField] float rateOfFire = 3;
    [SerializeField] float startShoot = 0;
    private float yAxis;
    private float xAxis;
    private float zAxis;
    private new MeshRenderer renderer;
    // Start is called before the first frame update
    void Start() {
        renderer = GetComponent<MeshRenderer>();
        
        InvokeRepeating("Shoot", startShoot, rateOfFire);
        xAxis = gameObject.transform.position.x;
        yAxis = gameObject.transform.position.y;
        zAxis = gameObject.transform.position.z;
    }

    void Shoot() {
        UnityEngine.Vector3 size = renderer.bounds.size;
        GameObject newBullet = Instantiate(bullet, new UnityEngine.Vector3(xAxis, yAxis, zAxis), transform.rotation);

    }
    // Update is called once per frame
    void Update() {
        
    }
}
