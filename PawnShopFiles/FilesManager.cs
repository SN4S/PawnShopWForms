using System;
using System.Collections.Generic;
using System.IO;

namespace PawnShopFiles
{
    public class FilesManager
    {
        public string clientsFile = "clients.txt";
        public string employeesFile = "workers.txt";
        public string propertyFile = "property.txt";
        public string historyFile = "history.txt";
        
        
        public static List<Client> ReadClients(string path)
        {
            List<Client> clients = new List<Client>();
            using (StreamReader reader = new StreamReader(path)) 
            {
                var res = reader.ReadToEnd().Split('|');
                if (res.Length - 1 < 1) return clients;
                for(int i = 0; i < res.Length-1; i++)
                {
                    var fields = res[i].Split('#'); 
                    Client client = new Client(Convert.ToInt32(fields[0]), fields[1], fields[2],fields[3], fields[4]);
                    clients.Add(client);
                }
            }
            return clients;   
        }
        
        public static void WriteClients(List<Client> clients, string path)
        {
            string res = "";
            for(int i = 0; i < clients.Count; i++)
            {
                res += $"{clients[i]}|";
            }
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(res);
            }
        }
        
    }
}