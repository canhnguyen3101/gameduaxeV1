using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float thoiGianGioiHan = 30f;
    public bool ketThucGame = false;
    private static GameManager instance;
    public GameObject gameOverObject;
    public GameObject timeGameObject;

    private float thoiGianHoiKhiQuaCheckPoint = 31f;

    public static GameManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance=FindObjectOfType<GameManager>();
                if(instance==null)
                {
                    GameObject gameManagerGameObject = new GameObject("GameManager");
                    instance=gameManagerGameObject.AddComponent<GameManager>();
                }
            }
            return instance;
        }
    }

    private void Update() 
    {
        if(!ketThucGame)
        {
            thoiGianGioiHan -= Time.deltaTime;
            Debug.Log(thoiGianGioiHan);
            if(thoiGianGioiHan<=0)
            {
                timeGameObject.SetActive(false);
                gameOverObject.SetActive(true);
                KetThucGame();
            }
        }
    }
    public void KetThucGame()
    {
        ketThucGame = true;
    }
    public void QuaCheckPoint()
    {
        if(!ketThucGame)
        {
            thoiGianGioiHan = thoiGianHoiKhiQuaCheckPoint;
        }
    }
}
