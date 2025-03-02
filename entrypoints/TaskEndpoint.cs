using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using taskManager_netcore.models;
using taskManager_netcore.models.enums;

namespace taskManager_netcore.endpoints
{
    public class TaskEndpoint
    {
        static readonly HttpClient client = new HttpClient();
        private static string url;
        private static string path = "Task/";

        public TaskEndpoint()
        {
            url = Properties.Settings.Default.host;
        }

        public async Task<List<TaskModel>> GetTasks(int status = 9999)
        {
            var serviceURL = url + path;
            if (status != 9999)
            {
                serviceURL += $"?status={status}";
            }
            try
            {
                var response = await client.GetAsync(serviceURL);
                response.EnsureSuccessStatusCode();
                var jsonString = await response.Content.ReadAsStringAsync();
                if (String.IsNullOrEmpty(jsonString))
                {
                    return new List<TaskModel> { new() };
                }
                List<TaskModel> tasks = JsonConvert.DeserializeObject<List<TaskModel>>(jsonString);
                return tasks;
            }
            catch (HttpRequestException ex)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    EventLog.WriteEntry("UPSTask", "Exception " + ex.Message, EventLogEntryType.Error, 1017);
                }
            }
            return new List<TaskModel>();
        }

        public async Task<bool> CreateTask(TaskModel model)
        {
            var serviceURL = url + path;
            try
            {
                var response = await client.PostAsync(serviceURL, new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/JSON"));
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (HttpRequestException ex)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    EventLog.WriteEntry("UPSTask", "Exception " + ex.Message, EventLogEntryType.Error, 1017);
                }
            }
            return false;
        }

        //Due to lack of string serializer. A class object has to be created for this purpose
        public async Task<bool> UpdateTask(int taskID, string description)
        {
            var serviceURL = url + path;
            try
            {
                var body = JsonConvert.SerializeObject(new { Description = description });
                var response = await client.PutAsync(serviceURL + taskID, new StringContent(body, Encoding.UTF8, "application/JSON"));
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (HttpRequestException ex)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    EventLog.WriteEntry("UPSTask", "Exception " + ex.Message, EventLogEntryType.Error, 1017);
                }
            }
            return false;
        }

        public async Task<bool> DeleteTask(int taskID)
        {
            var serviceURL = url + path;
            try
            {
                var response = await client.DeleteAsync(serviceURL + taskID);
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (HttpRequestException ex)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    EventLog.WriteEntry("UPSTask", "Exception " + ex.Message, EventLogEntryType.Error, 1017);
                }
            }
            return false;
        }

        public async Task<bool> CompleteTask(int taskID)
        {
            var serviceURL = url + path;
            try
            {
                var body = JsonConvert.SerializeObject(new { status = (int)Enums.TaskStatus.Completed });
                var response = await client.PatchAsync(serviceURL + taskID, new StringContent(body, Encoding.UTF8, "application/JSON"));
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (HttpRequestException ex)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    EventLog.WriteEntry("UPSTask", "Exception " + ex.Data, EventLogEntryType.Error, 1017);
                }
            }
            return false;
        }
    }
}
