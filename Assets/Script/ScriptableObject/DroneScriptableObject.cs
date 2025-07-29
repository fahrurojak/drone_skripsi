using MVCs;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "DroneScriptableObject", menuName = "ScriptableObject/CreateNewDroneScriptableObject")]
    public class DroneScriptableObject : ScriptableObject
    {
        [Header("Drone Properties")]
        [Tooltip("Batas pitch (naik turun) untuk stabilitas vertikal")]
        public float MinMaxPitch = 15f;

        [Tooltip("Batas roll (miring kiri-kanan) untuk kestabilan sisi")]
        public float MinMaxRoll = 15f;

        [Tooltip("Kecepatan rotasi sumbu yaw (berputar)")]
        public float YawPower = 2.5f;

        [Tooltip("Kehalusan perpindahan gerak (semakin tinggi semakin lambat respons)")]
        public float SmoothMove = 4f;

        [Tooltip("Kecepatan horizontal drone")]
        public float Speed = 5f;

        [Tooltip("Jumlah maksimum bahan bakar")]
        public float MaxFuel = 200f;

        [Tooltip("Tingkat konsumsi bahan bakar per detik saat aktif")]
        public float FuelConsumptionRate = 0.5f;

        [Header("Drone Body Properties")]
        [Tooltip("Berat drone (pengaruh terhadap gravitasi dan fisika)")]
        public float DroneWeight = 0.6f;

        [Tooltip("Prefab drone yang digunakan di scene")]
        public DroneView DronePrefab;
    }
}
