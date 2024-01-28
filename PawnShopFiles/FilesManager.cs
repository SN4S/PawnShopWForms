using System;
using System.Collections.Generic;
using System.IO;

namespace PawnShopFiles
{
    public class FilesManager
    {
        public string clientsFile = "clients.txt";
        public string employeesFile = "employees.txt";
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
        
        public static List<Employee> ReadEmployees(string path)
        {
            List<Employee> employees = new List<Employee>();
            using (StreamReader reader = new StreamReader(path)) 
            {
                var res = reader.ReadToEnd().Split('|');
                if (res.Length - 1 < 1) return employees;
                for(int i = 0; i < res.Length-1; i++)
                {
                    var fields = res[i].Split('#'); 
                    Employee employee = new Employee(Convert.ToInt32(fields[0]), fields[1], fields[2],fields[3]);
                    employees.Add(employee);
                }
            }
            return employees;   
        }
        
        public static void WriteEmployees(List<Employee> employees, string path)
        {
            string res = "";
            for(int i = 0; i < employees.Count; i++)
            {
                res += $"{employees[i]}|";
            }
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(res);
            }
        }
        
        public static List<Histrory> ReadHistory(string path)
        {
            List<Histrory> history = new List<Histrory>();
            using (StreamReader reader = new StreamReader(path)) 
            {
                var res = reader.ReadToEnd().Split('|');
                if (res.Length - 1 < 1) return history;
                for(int i = 0; i < res.Length-1; i++)
                {
                    var fields = res[i].Split('#'); 
                    Histrory his = new Histrory(Convert.ToInt32(fields[0]), fields[1], fields[2],fields[3],fields[4],Convert.ToInt32(fields[5]),Convert.ToInt32(fields[6]));
                    history.Add(his);
                }
            }
            return history;   
        }
        
        public static void WriteHistory(List<Histrory> history, string path)
        {
            string res = "";
            for(int i = 0; i < history.Count; i++)
            {
                res += $"{history[i]}|";
            }
            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.Write(res);
            }
        }
    }
}