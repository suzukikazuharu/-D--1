using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomContloller : MonoBehaviour
{
    public bool OnBulletFlg;
    BomBulletScript bom;
    int bomMaxNo = 50;
    int bomNo = 0;
    //GameObject objBomBullet;
    //BomBulletScript bombullet;
    public float countTime;
    public GameObject BomBulletObj;
    public Transform Prefab;
    public bool BulletFlg = false;
    float randposx, randposy;

    // Start is called before the first frame update
    void Start()
    {


        //bombullet = objBomBullet.GetComponent<BomBulletScript>();

        randposx = Random.Range(-10, 10);
        randposy = Random.Range(-10, 10);

    }

    // Update is called once per frame
    void Update()
    {
        //float time = Time.deltaTime;
        //transform.Translate(-1 * time, 0, 0);

        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            for (int a = 0; a < 50; a++)
            {
                GameObject clone = Instantiate(BomBulletObj, this.transform.position, Quaternion.identity);
            }
            OnBulletFlg = true;
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            for (int a = 0; a < 50; a++)
            {
                GameObject clone = Instantiate(BomBulletObj, this.transform.position, Quaternion.identity);
            }
            OnBulletFlg = true;
            Destroy(this.gameObject);
        }

    }

}
