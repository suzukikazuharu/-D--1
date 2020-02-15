using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bom : MonoBehaviour
{
    int bomMaxNo = 50;
    int bomNo = 0;
    BomBulletScript bom;
    GameObject objBomBullet;
    public GameObject objBom;
    public GameObject BomBulletPrefab;
    //時間
    float timecount;
    //オブジェクト
    public GameObject BomBulletObj;
    public Transform Prefab;
    //ボムを使うための変数
    public bool BomFlg = false;
    float bomcreateCount;
    float bomcreateposx, bomcreateposy;

    // Start is called before the first frame update
    void Start()
    {
        //BomBulletObj = GameObject.Find("BomBulletPrefab");
        //objBom = GameObject.Find("Bom");


    }

    // Update is called once per frame
    void Update()
    {
        timecount = Time.time;


        if (timecount > bomcreateCount + 5)
        {
            BomFlg = true;
        }
        if (BomFlg == true) { 

            bomcreateposx = Random.Range(-9, 9);
            bomcreateposy = Random.Range(-4, 4);
            Instantiate(objBom, new Vector3(bomcreateposx, bomcreateposy, 0), Quaternion.identity);
            BomFlg = false;
            bomcreateCount = Time.time;
        }

    }
}
