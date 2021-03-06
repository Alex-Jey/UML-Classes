﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Class
{

     class Client //Base
        {
            //Нужен список функций из ТЗ

            private byte[] _memoryBuffer;
            private bool _serverConnected; 
            private DateTime _connectionStartTime;
          
            public string Name { get; set; }
            public string DeviceID { get; set; }
            public int IP { get; set; }
            public string MAC { get; set; }
            public string AccessToken{ private get; set; }          
         
            public Client()
            {
                 
            }
            
            public bool ConnectToServer(string AccessToken)
            {
                return true;
            }

            public bool DisconnectFromServer(string IP)
            {
                return true;
            }

            public bool SendQuery(List<Comand> Query) //Отправляем серву наш пакет на исполнение
            {
                return true;
            }
          
            public void SendErrorMessage()
            {
                 
            }
        }

        //////////////////////////////////////////////можно описать ряд исключений как для клиента так и для сервера
        class ClientException
        {
             public string exMessage;
             public DateTime exHappendTime;
        }
     
        class ServerDisconnectException: ClientException
        {
          
        }
        //////////////////////////////////////////////исключения клиента конец//////////////////////////////////////////////
        
        class MobileClient : Client //Расплодим
        {

        }

        class DestopClient : Client
        {

        }

        class Comand //Заворачиваем команду из байт в пакет
        {
            byte[] Events;
            public Comand MakeComand() { return new Comand(); }
        }

        public class Server
        {

        string IP;
        string ServerName;

        List<Client> ActiveClients; //Список подключенных 
        public Server(byte[] Configuration) { }//Инициализация server
        DataAnalyzer DataAnalyze; //Обработка данных с датчиков
        Cryptor ServerCryptSystem; //Угадайте что
        Journal Logs; //История
        bool CheckSensor(BaseSensor sensor) { return true; }

        string GenerateToken(Client client) { return "Token"; }
        void ReciveData(Client client) { } //Слушаем клиента подключенного

        SignalizationSystem Signalization; //Система сигнализации

        }

        class Journal
        {

        List<Log> DataBase;

            struct Log
            {
                Int64 IDLog;
                DateTime TimeChanges;
                string Description;
                Client client; //who the fuck trogal eto
                bool IsSuccessComand; //В журнала по разному метят ошибки и нет

            }
            void WriteLog(Log log) { }
            Log FindLog(DateTime date, int IDLog = 0) { return new Log(); }
            Log LastChanges() { return new Log(); }

        public void ShowJournal() { }

           public Server RestoreServerConfiguration(DateTime date, int IDLog = 0) { return new Server(new byte[0]); } //Вернуть состояние серва по логам
        }

       abstract class BaseSensor //Датчик сделаем абстрактным
        {
           abstract public string SensorID { get; set; }
            Dictionary<string, int> Params; //Имя датчика --зн-е
        abstract public void SendSensorState(Server server); //Кидаем серверу, там этим занимается DataAnalyzer
        }

    class SmokeDetector : BaseSensor
    {
        Dictionary<string, int> Params; //Имя датчика --зн-е

        public override string SensorID
        {
            get; set;       
        }

        public override void SendSensorState(Server server)
        {
        }
    }

    class MotionDetector : BaseSensor
    {
        public override string SensorID
        {
            get; set;
        }

        public override void SendSensorState(Server server)
        {
            
        }

    }

    class VoltageSensor : BaseSensor
    {
        int CriticalLevel;
        int CurrentLevel;
        public override string SensorID
        {
            get; set;
        }
        public override void SendSensorState(Server server)
        {
            
        }
    }

    class DataAnalyzer // Анализ данных с датчика
        {
            Dictionary<BaseSensor, List<int>> NormalValueDiapasonl;

            int AnalyzeSensor(BaseSensor CurrentSensor) { int Risk = 0; return Risk; }
        }

    class Cryptor //Шифровка 
        {
            public byte[] Key; //Кто хочет поуминчать, где должен быть ключ?
            public byte[] EncryptData(byte[] Data) { return new byte[0]; }
            public byte[] DecryptData(byte[] Data) { return new byte[0]; }
        }

    class Package
        {
        static public byte[] Header = new byte[8];
        static public byte[] Protocol = new byte[16];
        static public byte[] SorceIP = new byte[32];
        static public byte[] DestinationIP = new byte[32];
        }

    /// <summary>
    /// Класс моей части сигналки
    /// </summary>
    class DeviceLock
    {
      public string IDLock; //Имя замка
      public bool StateLock { get; set; } //Состояние
      public  string TechDescription;    
    }

    class SignalizationSystem
    {
        bool State; //OnOff
        List<DeviceLock> AllLocks; //Замки дома
        List<string> NumberPhonesToAlarm; //Номера для звонков в случае тревоги
        public bool TurnOnAllarm(BaseSensor speaker = null) //Включить сирену
        {
            return true;
        }
        public void CallEmergency(string number) //Звоним в службы
        { }
     
        public void BlockAllHome() { } //Весь дом
        void BlockLock(DeviceLock Lock) { } //Конкретный замок
        void SendNotification() { }
        UserNotification SystemNotification;
    }

    class UserNotification //оповещения
    {
        string Description; //что
        Client UserName; //кому
        UserNotification(string Description ="", string UserName="User") { } //формиурем
        void SendNotification(Client client) { } //отсылаем
    }

    /// <summary>
    /// Херачь сюда коммуникации 
    /// </summary>



    class Camera
    {
        int Port { get; set; }
        string Name { get; set; }
        bool State { get; set; }
        int CurrentAngle { get; set; }
        byte[] Buffer;

        void RecieveVideo() { }
        int SearchVideo(string param) { return 0} 
        void SendVideo(List<Package> info) { }
        public void TurnState(bool state) { }
        public void MoveAngle(int delta) { }
        
    }

    class VideoSystem

    {

        byte[] HDD;
        List<Camera> LinkedCamers;
        Journal VideoArchive = new Journal();
        void TurnOnOff(Camera camera, bool state) { }
        void MoveCamere(Camera camera, int angle) { }

    }



    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
