using MVCs;
using System.Collections;
using UI;
using UnityEngine;

namespace Tutorial
{
    public class GameTutorialView : MonoBehaviour
    {
        [SerializeField] private GameObject[] gasLocationMarker;
        [SerializeField] private float tutorialDisableTimer = 5f;
        private int tutorialIndex = 7;
        private string tutorialText;
        private Coroutine timer;

        public bool isTutorialActive;

        private void Start ()
        {
            LoadTutorialStatus();
            DisableGasLocationMarker();
        }

        void Update()
        {
            if(isTutorialActive)
            {
                HandleTutorialPopUps();
                HandleTutorials();
            }
            else
            {
                UIService.Instance.GetTutorialPopUp().SetActive(false);
            }
        }

        public void LoadTutorialStatus()
        {
            isTutorialActive = PlayerPrefs.GetInt("IsTutorialActive", 1) == 1;
            UIService.Instance.SetTutorialToggle(isTutorialActive);
        }

        public void SaveTutorialStatus()
        {
            int setTutorialActiveStatus = UIService.Instance.GetIsTutorialActive() ? 1 : 0;
            PlayerPrefs.SetInt("IsTutorialActive", setTutorialActiveStatus);
            PlayerPrefs.Save();
        }

        public void SetTutorialStatus(bool isActive)
        {
            isTutorialActive = isActive;
        }

        private void HandleTutorialPopUps()
        {
            if (tutorialIndex != 0)
            {
                UIService.Instance.GetTutorialPopUp().SetActive(true);
            }
            else
            {
                tutorialText = "Mantap! Saatnya ngegas bareng lagi sama Drone MyMedic.\nTugas sekarang: Antar obat lagi, cepat waktu coy, jangan sampe telat!";
                DisplayTutorial(tutorialText);
                timer = StartCoroutine(DisableTutorial(tutorialDisableTimer));
            }
        }

        private void HandleTutorials()
        {
            if(tutorialIndex == 7)
            {
                tutorialText = "Tekan tombol panah ↑ untuk naik dan tombol panah ↓ untuk turun.";
                DisplayTutorial(tutorialText);

                if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow))
                    tutorialIndex--;
            }
            else if(tutorialIndex == 6)
            {
                tutorialText = "Tekan tombol panah ← untuk berbelok ke kiri dan tombol panah → untuk berbelok ke kanan.";
                DisplayTutorial(tutorialText);

                if (Input.GetKeyDown(KeyCode.LeftArrow) ||  Input.GetKeyDown(KeyCode.RightArrow))
                    tutorialIndex--;
            }
            else if( tutorialIndex == 5)
            {
                tutorialText = "Tekan tombol W untuk maju dan tombol S untuk mundur.";
                DisplayTutorial(tutorialText);

                if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
                    tutorialIndex--;
            }
            else if(tutorialIndex == 4)
            {
                tutorialText = "Tekan tombol A untuk bergerak ke kiri dan tombol D untuk bergerak ke kanan.";
                DisplayTutorial(tutorialText);

                if ( Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
                    tutorialIndex--;
            }
            else if(tutorialIndex == 3)
            {
                tutorialText = "Cari dan dekati panah besar yang mengarah ke paket, lalu posisikan drone di atas paket dan tekan 'E' untuk mengambilnya.";
                DisplayTutorial(tutorialText);
               
                if (DroneService.Instance.DroneController.DroneView.IsAttached)
                    tutorialIndex--;
            }
            else if(tutorialIndex == 2)
            {
                tutorialText = "Cari lokasi pengantaran dan dekati, lalu posisikan drone di dalam lingkaran yang ditandai dan tekan 'E' untuk mengantarkan.";
                DisplayTutorial(tutorialText);

                if (!DroneService.Instance.DroneController.DroneView.IsAttached)
                    tutorialIndex--;
            }
            else if (tutorialIndex == 1)
            {
                EnableGasLocationMarker();

                tutorialText = "Jika bahan bakar drone habis (0), drone tidak akan bisa terbang. Untuk tetap bisa terbang, isi ulang bahan bakar. Datangi pom bensin yang ditandai dan tahan tombol 'E' untuk mengisi bahan bakar.";
                DisplayTutorial(tutorialText);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    tutorialIndex--;
                    DisableGasLocationMarker();
                }
                    
            }
        }

        private void DisplayTutorial(string text)
        {
            UIService.Instance.SetTutorialText(text);
        }

        private IEnumerator DisableTutorial(float seconds)
        {
            yield return new WaitForSeconds(seconds);
            UIService.Instance.GetTutorialPopUp().SetActive(false);
        }

        private void EnableGasLocationMarker()
        {
            for (int i = 0; i < gasLocationMarker.Length; i++)
                gasLocationMarker[i].SetActive(true);
        }

        private void DisableGasLocationMarker()
        {
            for (int i = 0; i < gasLocationMarker.Length; i++)
                gasLocationMarker[i].SetActive(false);
        }
    }
}