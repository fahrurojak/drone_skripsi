# Judul Skripsi : RANCANG BANGUN _GAME_ DRONE MEDIS UNTUK PENANGANAN DARURAT DI KERUMUNAN ACARA OUTDOOR

📘 *Skripsi Sarjana S1 - Teknik Informatika*

Game Simulasi 3D yang menggambarkan skenario pengiriman bantuan medis menggunakan drone, khususnya dalam kondisi darurat di acara luar ruang seperti konser atau festival.

---

## 👤 Identitas Mahasiswa

- **Nama**   : Fahru Rojak
- **NIM**    : 55201121010 
- **Jurusan**: Teknik Informatika  
- **Universitas**: [Universitas Nurtanio Bandung]

---

## 🎮 Ringkasan Gameplay

Dalam game ini, pemain bertugas mengendalikan drone untuk mengambil dan mengantarkan paket medis ke lokasi tujuan yang telah ditentukan dalam batas waktu tertentu. Game ini menggabungkan elemen simulasi dan puzzle.

### 🎯 Tujuan Game

- Melatih ketepatan waktu dan kendali dalam kondisi darurat  
- Memberikan edukasi logistik medis modern menggunakan drone  
- Sarana simulasi ringan dalam konteks darurat outdoor

---

## 🕹️ Kontrol Permainan

| Tombol            | Fungsi                          |
|-------------------|----------------------------------|
| ⬆ / ⬇ Arrow       | Naik / Turun drone               |
| ⬅ / ➡ Arrow       | Putar Kiri / Kanan               |
| **W / S**         | Maju / Mundur                   |
| **A / D**         | Gerak Kiri / Kanan              |
| **E**             | Ambil / Lepas Paket             |

---

## 🛠️ Teknologi & Fitur

- ✅ **Unity 3D dan C#**
- ✅ Menggunakan Unity **New Input System**
- ✅ Arsitektur **MVC** untuk pemisahan logika antar objek
- ✅ Menggunakan **ScriptableObject** untuk pengaturan konfigurasi
- ✅ Implementasi **Observer Pattern** untuk trigger interaksi
- ✅ **Object Pooling** untuk efisiensi dalam spawn paket & lokasi

---

## 📁 Struktur Folder Proyek (Unity)

Delivery-Drone/
├── Assets/
│ ├── Scripts/
│ │ ├── Drone/ # Kendali drone & logika terbang
│ │ ├── Package/ # Attach/detach paket
│ │ ├── InputSystem/ # Input Unity baru
│ │ ├── Event/ # Event & observer
│ │ ├── Managers/ # GameManager, UIManager, SpawnManager
│ │ └── Utilities/ # Fungsi pendukung
│ ├── Prefabs/ # Prefab drone, paket, lokasi
│ ├── Scenes/ # MainScene, TutorialScene, dst.
│ ├── ScriptableObjects/ # Data konfigurasi kecepatan, waktu, nama lokasi
│ ├── UI/ # Canvas, tombol, teks
│ ├── Materials/ # Material objek 3D
│ ├── Audio/ # SFX dan musik latar
│ ├── Animations/ # (Opsional) animasi drone atau UI
│ └── Sprites/ # Icon & gambar UI
├── Packages/ # Dependency Unity (URP, Input System, dsb)
├── ProjectSettings/ # Pengaturan proyek Unity
├── UserSettings/ # Konfigurasi lokal pengguna
└── README.md # Dokumentasi proyek ini

---

## 🖼️ Screenshoot Projek

| Cuplikan | Deskripsi |
|---------|-----------|
| ![1](https://github.com/Tivra-Raj/Delivery-Drone/assets/107213542/d0e82ffb-63bf-4e8c-a844-6133a7bc08f5) | Area awal permainan |
| ![2](https://github.com/Tivra-Raj/Delivery-Drone/assets/107213542/d5bbfe7a-e4a8-4de6-b35f-9ce9f6c1b821) | Drone membawa paket |
| ![3](https://github.com/Tivra-Raj/Delivery-Drone/assets/107213542/74348603-8cff-4cb5-8778-688ae4cec50a) | Lokasi pengantaran |
| ![4](https://github.com/Tivra-Raj/Delivery-Drone/assets/107213542/11e46cb4-5c25-48fd-b12a-192c201aad7d) | Titik drop-off |
| ![5](https://github.com/Tivra-Raj/Delivery-Drone/assets/107213542/8dfdc5cf-eda8-4e8e-a8e5-004fa14cb329) | Tampilan drone dari atas |

---

## 🙏 Ucapan Terima Kasih

Terima kasih atas inspirasi dan kontribusi dari:

- **Mayank Grover**  
- **Malhar Devasthali**  
- **Arindam Bharti**

Serta dosen pembimbing dan teman-teman yang turut mendukung pengerjaan tugas akhir ini.

---

> 🧑‍💻 *Dokumentasi ini dibuat sebagai bagian dari Skripsi Program Sarjana Teknik Informatika.*
