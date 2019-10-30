using UnityEngine;

public class Car_control : MonoBehaviour
{
   [Header("移動速度")]
   [Range(1,230)]
   public int SpeedMove = 30;
   [Header("旋轉速度")]
   [Range(1, 100)]
   public int SpeedTurn = 25;
   [Header("汽車檔次")]
   [Range(1, 6)]
   public int CarShift = 2;
   [Header("汽車品牌")]
   public string Brand = "BMW";
   [Header("是否煞車")]
   public string Brakes = "Brakes";
}
