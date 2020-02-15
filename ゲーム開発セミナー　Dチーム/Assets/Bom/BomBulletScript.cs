using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomBulletScript : MonoBehaviour
{
    Vector3 randlocation;
    float randposx, randposy;
    public float speed;
    public bool shotFlg = false;
    float countTime = 0;
    float DestroyTime;
    // Start is called before the first frame update
    void Start()
    {
        randposx = Random.Range(-10, 10);
        randposy = Random.Range(-10, 10);
        DestroyTime = Time.time+2;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 randpos = new Vector3(randposx,randposy,0);

        float time = Time.deltaTime;
        transform.Translate(randpos*time*speed);

        Vector3 bulletpos = transform.position;

        if (bulletpos.x > 8.5f)
        {
            randposx = Random.Range(-10, 0);
            randposy = Random.Range(-10, 10);
            transform.Translate(randposx * time * speed, randposy * time * speed, 0);
        }
        if (bulletpos.x < -8.5f)
        {
            randposx = Random.Range(0, 10);
            randposy = Random.Range(-10, 10);
            transform.Translate(randposx * time * speed, randposy * time * speed, 0);
        }
        if (bulletpos.y > 4.5f)
        {
            randposx = Random.Range(-10, 10);
            randposy = Random.Range(0, -5);
            transform.Translate(randposx * time * speed, randposy * time * speed, 0);
        }
        if (bulletpos.y < -4.5f)
        {
            randposx = Random.Range(-10, 10);
            randposy = Random.Range( 0, 5);
            transform.Translate(randposx * time * speed, randposy * time * speed, 0);
        }



        countTime = Time.time;
        if(countTime > DestroyTime)
        {
            Destroy(this.gameObject);
        }
        

    }
    public void getFlg(bool flg)
    {
         shotFlg = flg;
    }




    protected Vector2 GetVelocity(float direction, float speed)
    {
        // Setting velocity.
        Vector2 v;
        v.x = Mathf.Cos(Mathf.Deg2Rad * direction) * speed;
        v.y = Mathf.Sin(Mathf.Deg2Rad * direction) * speed;
        return v;
    }
}
