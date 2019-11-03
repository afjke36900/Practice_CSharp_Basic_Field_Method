using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Car : MonoBehaviour
{
    [Header("移動速度")]
    [Range(0, 230)]
    public int SpeedMove = 30;
    [Header("旋轉速度")]
    [Range(0, 100)]
    public int SpeedTurn = 50;
    [Header("汽車檔次")]
    [Range(1, 6)]
    public int CarShift = 2;
    [Header("汽車品牌")]
    public string Brand = "BMW";
    [Header("是否煞車"), Tooltip("用來判定要不要煞車")]
    public bool Brakes;
    [Header("汽車顏色")]
    public Color Carcolor;

    public Transform car;
    public void CarMoveforward()
    {
        car.Translate(0f, 0f, SpeedMove * Time.deltaTime);
    }
    public void CarMoveback()
    {
        car.Translate(0f, 0f, -SpeedMove * Time.deltaTime);
    }
    public void CarLeft()
    {
        car.Rotate(0f, -SpeedTurn * Time.deltaTime, 0f);
    }
    public void CarRight()
    {
        car.Rotate(0f, SpeedTurn * Time.deltaTime, 0f);
    }
    private void Update()
    {
        CarMoveforward();
        CarMoveback();
        CarLeft();
        CarRight();
    }
}
