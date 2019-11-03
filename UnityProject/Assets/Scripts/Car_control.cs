using UnityEngine;
using System.Collections;

public class Car_control : MonoBehaviour
{
   [Header("移動速度")]
   [Range(1,230)]
   public int SpeedMove = 50;
   [Header("旋轉速度")]
   [Range(1, 100)]
   public int SpeedTurn = 20;
   [Header("汽車檔次")]
   [Range(1, 6)]
   public int CarShift = 2;
   [Header("汽車品牌")]
   public string Brand = "BMW";
   [Header("是否煞車"),Tooltip("用來判定要不要煞車")]
   public bool Brakes;
    [Header("汽車顏色")]
   public int Color =color;

    public Transform Car;

    private void MoveCar()
    {
     car.Translate（Vector3.forward * Time.deltaTime,0,0）;
     car.Translate（Vector3.up * Time.deltaTime，Space.World）;
    }
}
