using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Class
{

     class Client //Base
        {
            //Нужен список функций из ТЗ

            public string NameClient { get; set; }
            public string DeviceID { get; set; }
            public byte[] MemoryBuffer { get; set; }

            public void AcceptData(string IP)
            {

            }

            public bool ConnectToServer(string IP)
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
        }

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
            bool CheckSensor(Sensor sensor) { return true; }

            string GenerateToken(Client client) { return "Token"; }
            void ReciveData(Client client) { } //Слушаем клиента подключенного
        }

        class Journal
        {
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
            Server RestoreServerConfiguration(DateTime date, int IDLog = 0) { return new Server(new byte[0]); } //Вернуть состояние серва по логам
        }

        class Sensor //Датчик
        {
            string SensorID;
            Dictionary<string, int> Params; //Имя датчика --зн-е
            void SendSensorState(Server server) { } //Кидаем серверу, там этим занимается DataAnalyzer
        }

        class DataAnalyzer // Анализ данных с датчика
        {
            Dictionary<Sensor, List<int>> NormalValueDiapasonl;

            int AnalyzeSensor(Sensor CurrentSensor) { int Risk = 0; return Risk; }
        }

        class Cryptor //Шифровка 
        {
            public byte[] Key; //Кто хочет поуминчать, где должен быть ключ?
            public byte[] EncryptData(byte[] Data) { return new byte[0]; }
            public byte[] DecryptData(byte[] Data) { return new byte[0]; }
        }

        class Packet
        {
            public byte[] Header = new byte[8];
            public byte[] Protocol = new byte[16];
            public byte[] SorceIP = new byte[32];
            public byte[] DestinationIP = new byte[32];
        }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
